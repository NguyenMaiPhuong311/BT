using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duan2
{
    public enum FIELD { FLD_EMPTY=' ',FLD_X='X', FLD_O='O'}
    internal class Cell
    {
        FIELD fieldState = FIELD.FLD_EMPTY;
        public Cell(FIELD fieldState = FIELD.FLD_EMPTY)
        {
            this.fieldState = fieldState;
        }

        public FIELD FieldState { get => fieldState; set => fieldState = value; }
        //kiểm tra trống không
        public bool isEmpty()
        {
            return (fieldState == FIELD.FLD_EMPTY);
        }
        public void markField(char c)
        {
            if (c == 'X')
                fieldState = FIELD.FLD_X;
            else if  (c == 'O')
                fieldState = FIELD.FLD_O;
            else
                fieldState = FIELD.FLD_EMPTY;
        }
    }
}
