namespace AdventOfCode2021.Data
{
    public class Line
    {
        public (int, int) FromCoordinate { get; }
        public (int, int) ToCoordinate { get; }
        public bool IsHorizontal
        {
            get 
            {
                if (this.FromCoordinate.Item2 == this.ToCoordinate.Item2)
                {
                    return true;
                }
                return false;
            }
        }
        public bool IsVertical
        {
            get 
            {
                if (this.FromCoordinate.Item1 == this.ToCoordinate.Item1)
                {
                    return true;
                }
                return false;
            }
        }

        public Line((int, int) from, (int, int) to)
        {
            this.FromCoordinate = from;
            this.ToCoordinate = to;
        }
    }
}