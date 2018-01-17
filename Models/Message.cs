namespace VlackApi.Models
{
  public class Message
  {
    public long Id { get; set; }
    public string body { get; set; }
    public long ChannelId { get; set; }
  }
}