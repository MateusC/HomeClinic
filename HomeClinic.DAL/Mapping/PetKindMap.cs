using HomeClinic.Domain.Entity;

namespace HomeClinic.DAL.Mapping
{
    class PetKindMap : AbstractMap<PetKind>
    {
        public PetKindMap()
        {
            Table("EMPRESA_ESPECIE");

            Id(x => x.Id).Column("IDESPECIE").Not.Nullable();

            Map(x => x.Name).Column("NOME").Nullable();

            Map(x => x.Initials).Column("SIGLA").Nullable();
        }
    }
}
