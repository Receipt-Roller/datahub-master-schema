using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsRRDataHubMasterSchema
{
    /// <summary>
    /// Represents a schedule based on the schema.org definition.
    /// More details: https://schema.org/Schedule
    /// </summary>
    public class Schedule : Thing
    {
        public Schedule(string identifier, string name) : base(identifier, name)
        {
        }

        /// <summary>
        /// Specifies the day of the week on which the event takes place.
        /// Using integer representation where 1 corresponds to Monday.
        /// </summary>
        public int? ByDay { get; set; }

        /// <summary>
        /// Specifies the month (1-12) in which the event occurs.
        /// </summary>
        public int? ByMonth { get; set; }

        /// <summary>
        /// Specifies the day of the month on which the event occurs.
        /// </summary>
        public int? ByMonthDay { get; set; }

        /// <summary>
        /// Specifies the week within the month (1-5) in which the event occurs.
        /// For instance, 2 might refer to the second week of the month.
        /// </summary>
        public int? ByMonthWeek { get; set; }

        /// <summary>
        /// Duration of the event based on the schema.org definition.
        /// More details: https://schema.org/Duration
        /// </summary>
        public Thing? Duration { get; set; }

        /// <summary>
        /// Specifies the end date of the event's occurrence.
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Specifies the end time of the event on a given date.
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// List of dates on which the event will not take place.
        /// </summary>
        public List<DateTime>? ExceptDates { get; set; }

        /// <summary>
        /// The number of times the event will repeat.
        /// </summary>
        public int? RepeatCount { get; set; }

        /// <summary>
        /// Describes the frequency at which the event repeats (e.g., daily, weekly).
        /// </summary>
        public Thing? RepeatFrequency { get; set; }

        /// <summary>
        /// Specifies the start date of the event's occurrence.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Specifies the start time of the event on a given date.
        /// </summary>
        public DateTime StartTime { get; set; }
    }

}
