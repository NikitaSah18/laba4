namespace Guarantee.Models
{
    public class GuaranteeAgreement
    {
        public int NumberOfContract { get; set; }
        public string DateOfContract { get; set; }

        public int GuaranteeAgreementId { get; set; }

        public TheGuarantor TheGuarantor { get; set; }

    }
}

