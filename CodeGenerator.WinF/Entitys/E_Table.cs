using DapperExtensions.Mapper;

namespace CodeGenerator.WinF.Entitys
{
    public class Mapper_E_Table:ClassMapper<E_Table>
    {
        public Mapper_E_Table()
        {
            Map(x => x.TABLE_NAME).Column(nameof(E_Table.TABLE_NAME));
        }
    }
    public class E_Table
    {
        /// <summary>
        /// 
        /// </summary>
        public string TABLE_NAME { get; set; }
    }
}
