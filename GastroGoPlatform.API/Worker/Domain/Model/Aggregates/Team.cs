﻿using GastroGoPlatform.API.Worker.Domain.Model.Entities;

namespace GastroGoPlatform.API.Worker.Domain.Model.Aggregates
{
    /// Team Aggregate
    /// <summary>
    ///     This class represents the Team Aggregate. Used to store each team and its respective leader and members. 
    /// </summary>
    public class Team
    { 
        public Guid Id { get; set; }
        public required string TeamName { get; set; }
        public required TeamLeader Leader { get; set; }
        public required List<TeamMember> Members { get; set; }

        public Team(string teamName, TeamLeader leader)
        {
            Id = Guid.NewGuid();
            TeamName = teamName;
            Leader = leader;
            Members = new List<TeamMember>();
        }

        public void AddMember(TeamMember teamMember)
        {
            Members.Add(teamMember);
        }

        public void RemoveMember(TeamMember teamMember)
        {
            Members.Remove(teamMember);
        }
    }
}
