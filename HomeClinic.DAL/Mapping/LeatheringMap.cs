using HomeClinic.Domain.Entity;

namespace HomeClinic.DAL.Mapping
{
    class LeatheringMap : AbstractMap<Leathering>
    {
        public LeatheringMap()
        {
            Table("EMPRESA_TOSA");

            Id(x => x.Id).Column("IDTOSA").Not.Nullable();

            Map(x => x.Name).Column("NOME").Nullable();

            Map(x => x.Observation).Column("OBS").Nullable();
        }
    }
}
