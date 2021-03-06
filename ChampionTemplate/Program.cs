﻿#region License

/*
 Copyright 2014 - 2015 Nikita Bernthaler
 Program.cs is part of ChampionTemplate.

 ChampionTemplate is free software: you can redistribute it and/or modify
 it under the terms of the GNU General Public License as published by
 the Free Software Foundation, either version 3 of the License, or
 (at your option) any later version.

 ChampionTemplate is distributed in the hope that it will be useful,
 but WITHOUT ANY WARRANTY; without even the implied warranty of
 MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 GNU General Public License for more details.

 You should have received a copy of the GNU General Public License
 along with ChampionTemplate. If not, see <http://www.gnu.org/licenses/>.
*/

#endregion License

namespace ChampionTemplate
{
    internal class Program
    {
        // ReSharper disable once UnusedParameter.Local
        private static void Main(string[] args)
        {
            /*
             * Start the bootstrap which is responsible for setting up the application.
             * - Starting the core
             * - Loading the correct champion class
             * - Possible other stuff if required
             */
            Bootstrap.Init();
        }
    }
}