using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caro2
{
    class Cell
    {
        public enum FIELD { Field_Empty = ' ', Field_X = 'X', Field_O = 'O'};
        public FIELD fieldStatus;

        public Cell() 
        {
            fieldStatus = FIELD.Field_Empty;
        }
        public FIELD FieldStatus { get => fieldStatus; set => fieldStatus = value; }
        public bool IsEmpty()
        {
            return fieldStatus == FIELD.Field_Empty;
        }
        public void PutCell(char choice)
        {
            if (choice == 'X')  
                this.fieldStatus = FIELD.Field_X; 
            else
                this.fieldStatus = FIELD.Field_O; 
        }
    }
}
