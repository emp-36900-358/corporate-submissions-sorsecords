using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class search_Grid
{
    public enum GroundType
    {
        NotRoad,
        Road,
    }

    /// <summary>
    /// ���W
    /// </summary>
    [Serializable]
    public struct Coord
    {
        public int x;
        public int y;

        public static Coord zero = new Coord() { x = 0, y = 0 };
        public static Coord one = new Coord() { x = 1, y = 1 };
        public static Coord left = new Coord() { x = -1, y = 0 };
        public static Coord up = new Coord() { x = 0, y = 1 };
        public static Coord right = new Coord() { x = 1, y = 0 };
        public static Coord down = new Coord() { x = 0, y = -1 };
        public static Coord operator +(Coord a, Coord b) { return new Coord(a.x + b.x, a.y + b.y); }
        public static Coord operator -(Coord a, Coord b) { return new Coord(a.x - b.x, a.y - b.y); }

        public float SqrMagnitude { get { return x * x + y * y; } }
        public float Magnitude { get { return Mathf.Sqrt(SqrMagnitude); } }

        public Coord(int x, int y)
        {
            this.x = x;
            this.y = x;
        }
    }

    /// <summary>
    /// �Z��
    /// </summary>
    [Serializable]
    public class Cell
    {
        public Coord coord;
        public GroundType groundType;
    }

    [SerializeField]
    private List<Cell> _cells;
    public List<Cell> Cells { get { return _cells; } }
    [SerializeField]
    private int _columnCount;
    public int ColumnCount { get { return _columnCount; } }
    [SerializeField]
    private int _rowCount;
    public int RowCount { get { return _rowCount; } }
    [SerializeField]
    private Coord _startCellCoord;
    public Cell StartCell { get { return GetCell(_startCellCoord); } set { _startCellCoord = value.coord; } }
    [SerializeField]
    private Coord _goalCellCoord;
    private search_Grid grid;

    public Cell GoalCell { get { return GetCell(_goalCellCoord); } set { _goalCellCoord = value.coord; } }

    public search_Grid(int columnCount, int rowCount)
    {
        _columnCount = columnCount;
        _rowCount = rowCount;
        _cells = new List<Cell>();
        for (int i = 0; i < columnCount * rowCount; i++)
        {
            var column = Mathf.FloorToInt(i / rowCount);
            var row = i % rowCount;
            var coord = new Coord() { x = column, y = row };
            _cells.Add(new Cell() { coord = coord });
        }
    }

    public search_Grid(search_Grid grid)
    {
        this.grid = grid;
    }

    /// <summary>
    /// �Z�����擾����
    /// </summary>
    public Cell GetCell(Coord coord)
    {
        return GetCell(coord.x, coord.y);
    }

    /// <summary>
    /// �Z�����擾����
    /// </summary>
    public Cell GetCell(int x, int y)
    {
        if (IsValidCoord(x, y))
        {
            var index = x * _rowCount + y;
            return _cells[index];
        }
        else
        {
            return null;
        }
    }
    /// <summary>
    /// ���݂���Z����
    /// </summary>
    public bool IsValidCoord(int x, int y)
    {
        return x >= 0 && x < _columnCount && y >= 0 && y < _rowCount;
    }

    /// <summary>
    /// �אڂ���Z�����擾����
    /// </summary>
    public List<Cell> GetAdjacences(int x, int y)
    {
        var adjacences = new List<Cell>();
        var offsets = new Coord[] { Coord.left, Coord.up, Coord.right, Coord.down };
        for (int i = 0; i < offsets.Length; i++)
        {
            var cell = GetCell(x + offsets[i].x, y + offsets[i].y);
            if (cell != null)
            {
                adjacences.Add(cell);
            }
        }
        return adjacences;
    }
}
