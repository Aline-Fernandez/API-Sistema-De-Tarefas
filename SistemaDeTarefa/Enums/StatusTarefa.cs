using System.ComponentModel;

namespace SistemaDeTarefa.Enums
{
    public enum  StatusTarefa
    {
        [Description("A Fazer")]
        AFazer = 1,
        [Description("Em Andamento")]
        EmAndamento = 2,
        [Description("Concluída")]
        Concluida = 3,
    }
}
