//written by Tariro Grace Shumba
// 2/1/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Defense_of_Consolas
{
    public class DefenseOfConsolas
    {
        // class variables 
        private int row = 0;
        private int column = 0;

        // getters and setters
        public int Row
        {
            get { return this.row; }
            set { this.row = value; }
        }

        public int Column
        {
            get { return this.column; }
            set { this.column = value; }
        }

        // methods

        public int DeploymentRow()
        {
            int deploymentRow = this.Row;
            return deploymentRow;
        }
        public int DeploymentCol()
        {
            int deploymentCol = this.Column;
            return deploymentCol;
        }


        // constructors 

        public DefenseOfConsolas(int aRow, int aColumn)
        {
            this.Row = aRow;
            this.Column = aColumn;

        }
        //overriding tostring 

        public override string ToString()
        {
            string msg = " ";
            msg += $"Deploy to :\n ({DeploymentRow()},{DeploymentCol() -1} ) \n ({DeploymentRow() - 1},{DeploymentCol()}) " +
                $"\n ({DeploymentRow() - 1},{DeploymentCol() + 1}) \n ({DeploymentRow() + 1},{DeploymentCol() }) \n";
            return msg;
        }

    }
}
