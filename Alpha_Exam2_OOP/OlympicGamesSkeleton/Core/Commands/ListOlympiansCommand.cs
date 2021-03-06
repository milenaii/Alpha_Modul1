﻿using System.Collections.Generic;
using System.Linq;
using System.Text;

using OlympicGames.Core.Commands.Abstracts;
using OlympicGames.Core.Factories;
using OlympicGames.Utils;
using OlympicGames.Olympics;

namespace OlympicGames.Core.Commands
{
    public class ListOlympiansCommand : Command, ICommand
    {
        private string key;
        private string order;

        public ListOlympiansCommand(IList<string> commandParameters)
            : base(commandParameters)
        {
            // TODO: Implement here

            // if one or both of the parameters exists in the list, assign the value, otherwise assign default

            string passedKey = commandParameters.Count() >= 1 ? commandParameters[0] : "firstname";

            string passedOrder = commandParameters.Count() >= 2 ? commandParameters[1] : "asc";

            this.key = string.IsNullOrWhiteSpace(passedKey) ? "firstname" : passedKey;

            this.order = string.IsNullOrWhiteSpace(passedOrder) ? "asc" : passedOrder;
            
        }

        // Use it. It works!
        public override string Execute()
        {
            //
            if (this.Committee.Olympians.Count == 0)
            {
                return GlobalConstants.NoOlympiansAdded;
            }
            //

            var stringBuilder = new StringBuilder();
            var sorted = this.Committee.Olympians.ToList();

            stringBuilder.AppendLine(string.Format(GlobalConstants.SortingTitle, this.key, this.order));

            if (this.order.ToLower().Trim() == "desc")
            {
                sorted = this.Committee.Olympians.OrderByDescending(x =>
                {
                    return x.GetType().GetProperties().FirstOrDefault(y => y.Name.ToLower() == this.key.ToLower()).GetValue(x, null);
                }).ToList();
            }
            else
            {
                sorted = this.Committee.Olympians.OrderBy(x =>
                {
                    return x.GetType().GetProperties().FirstOrDefault(y => y.Name.ToLower() == this.key.ToLower()).GetValue(x, null);
                }).ToList();
            }

            foreach (var item in sorted)
            {
                stringBuilder.AppendLine(item.ToString());
            }

            return stringBuilder.ToString();
        }
    }
}
