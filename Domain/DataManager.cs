using MyCompanyApp.Domain.Repositories.Abstract;

namespace MyCompanyApp.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields {  get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }
        public DataManager (ITextFieldsRepository textFieldRepository, IServiceItemsRepository serviceItemsRepository)
        {
            TextFields = textFieldRepository;
            ServiceItems = serviceItemsRepository;
        }
    }
}
