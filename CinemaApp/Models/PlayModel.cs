using System;
namespace CinemaApp.Models
{
    public class PlayModel
    {
        public int PlayId { get; set; }
        public int MovieId { get; set; }
        public int RoomId { get; set; }
        public DateTime StartDateTime { get; set; }
        public TimeSpan PauseDuration { get; set; }
        public float Price { get; set; }
    }
}
