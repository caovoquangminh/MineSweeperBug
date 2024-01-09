using System;

namespace MineSweeper.DTO
{
    internal partial class MineSweeperCellDTO
    {
        internal bool bIsOpened;

        internal int iAmountBombAround;

        public static implicit operator MineSweeperCellDTO(int v)
        {
            throw new NotImplementedException();
        }
    }

    internal partial class MineSweeperCellDTO
    {
        public override string ToString()
        {
            return "["
                    + $"bIsOpened={bIsOpened}, "
                    + $"iAmountBombAround={iAmountBombAround}, "
                 + "]";
        }
    }
}
