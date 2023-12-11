using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_3er_semestre_Algoritmos_C__WF
{
    internal class BinaryTreeNode
    {
        public int Value;
        public BinaryTreeNode Left, Right;

        public BinaryTreeNode(int value)
        {
            Value = value;
            Left = Right = null;
        }
    }
}
