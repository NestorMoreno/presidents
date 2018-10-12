using DTO;

namespace BLL
{
    public class PresidentOperationsFactory
    {
        public virtual IPresidentOperations CreateSalesOperations(President president) {
            IPresidentOperations personalInfo = null;

            switch (president.Country)
            {
                case "US":
                    personalInfo = new PersonalInformation();
                    break;

                default:
                    break;
            }

            return personalInfo;
        }
    }
}
