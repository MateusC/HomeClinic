using HomeClinic.Domain.Entity;

namespace HomeClinic.DAL.Mapping
{
    class PrescriptionMap : AbstractMap<Prescription>
    {
        public PrescriptionMap()
        {
            Table("EMPRESA_RECEITUARIO");

            Id(x => x.Id).Column("IDRECEITUARIO").Not.Nullable();

            Map(x => x.Date).Column("DATA").Nullable();

            References(x => x.Account).Column("IDCONTA").Nullable();

            References(x => x.Pet).Column("IDANIMAL").Nullable();
        }
    }
}
