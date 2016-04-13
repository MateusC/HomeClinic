using HomeClinic.Domain.Entity;

namespace HomeClinic.DAL.Mapping
{
    class BreedMap : AbstractMap<Breed>
    {
        public BreedMap()
        {
            Table("EMPRESA_RACA");

            Id(x => x.Id).Column("IDRACA").Not.Nullable();

            Map(x => x.Name).Column("NOME").Nullable();

            References(x => x.Kind).Column("IDESPECIE").Nullable();
        }
    }
}
