public class SongProject
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImagePath { get; set; }
    public string Url { get; set; }
    public string Type { get; set; }
    public List<AudioFile> AudioFiles { get; set; }
    public ProductionCredits ProductionDetails { get; set; }
    public List<MusicTask> Tasks { get; set; }
    public string Lyrics { get; set; }
}