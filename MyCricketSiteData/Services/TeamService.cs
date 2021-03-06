﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCricketSiteData.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace MyCricketSiteData.Services
{
    public class TeamService : EntityService<Team>
    {
        //public IEnumerable<Team> getTeamsForTournament(string tournamentID)
        //{
        //    var tCursor = this.DBConnectionHandler.DBCollection.FindAllAs<Team>()
        //            .SetSortOrder(SortBy<Team>.Descending(g => g.TeamName))
        //            .Where(g => g.TournamentIds.Contains(tournamentID));
        //    return tCursor;
        //}
        public Team GetTeamByName(string name, string tournamentid)
        {

            var entityQuery = Query<Team>.EQ(e => e.TeamName, name);

            return this.DBConnectionHandler.DBCollection.FindOne(entityQuery);


        }

        public List<Team> GetTeambyIds(List<ObjectId> teamids)
        {

            return this.DBConnectionHandler.DBCollection.AsQueryable().OfType<Team>().Where(a => teamids.Contains(a.Id)).ToList<Team>();



        }


        public override void Update(Team entity)
        {
        }
    }
}
