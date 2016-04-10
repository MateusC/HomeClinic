using HomeClinic.Domain.Entity;

namespace HomeClinic.DAL.Mapping
{
    class CountryMap : AbstractMap<Country>
    {
        public CountryMap()
        {
            Table("EMPRESA_MUNICIPIO");

            Id(x => x.Id).Column("IDMUNICIPIO").Not.Nullable();

            Map(x => x.Name).Column("NOME").Nullable();

            References(x => x.State).Column("IDUF").Nullable();
        }
    }
}
