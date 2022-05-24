﻿namespace TravelerGuideApp.Domain.Entities
{
    public class UserExperience
    {
        public int UserId { get; set; }
        public int TravelItineraryId { get; set; }
        public int LocationId { get; set; }
        public string Priority { get; set; }
        public double Budget { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
        public TravelItinerary TravelItinerary { get; set; }
        public Location Location { get; set; }

        public UserExperience()
        {

        }

        public UserExperience(int userId, int travelItineraryId, int locationId, string priority, double budget, string description)
        {
            UserId = userId;
            TravelItineraryId = travelItineraryId;
            LocationId = locationId;
            Priority = priority;
            Budget = budget;
            Description = description;
        }
    }
}
