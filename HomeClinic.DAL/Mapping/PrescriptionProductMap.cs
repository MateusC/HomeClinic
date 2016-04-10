using HomeClinic.Domain.Entity;

namespace HomeClinic.DAL.Mapping
{
    class PrescriptionProductMap : AbstractMap<PrescriptionProduct>
    {
        public PrescriptionProductMap()
        {
            Table("EMPRESA_RECEITUARIO_PROD");

            Id(x => x.Id).Column("IDRECEITUARIO_PROD").Not.Nullable();

            Map(x => x.Amount).Column("QTD").Nullable();

            Map(x => x.Unit).Column("UNIDADE").Nullable();

            References(x => x.Prescription).Column("IDRECEITUARIO").Nullable();

            References(x => x.Medicine).Column("IDMEDICAMENTO").Nullable();
        }
    }
}
