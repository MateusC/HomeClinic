using HomeClinic.Domain.Entity;

namespace HomeClinic.DAL.Mapping
{
    class StateMap : AbstractMap<State>
    {
        public StateMap()
        {
            Table("EMPRESA_UF");

            Id(x => x.Id).Column("IDUF").Not.Nullable();

            Map(x => x.Name).Column("NOME").Nullable();

            Map(x => x.Initials).Column("UF").Nullable();
        }
    }
}
