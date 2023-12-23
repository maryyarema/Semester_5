namespace CommandsService.EventProcessing
{
    public interface IContactInformationProcessor
    {
        void ProcessContactInformation(string message);
    }
}