/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2020, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using BH.oM.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.Upgrader.v30
{
    public partial class Converter 
    {
        /***************************************************/
        /**** Public Methods                            ****/
        /***************************************************/

        public IObject ToNew(oM.Architecture.Elements.Level level)
        {
            if (level == null)
                return null;

            return new oM.Geometry.SettingOut.Level
            {
                Elevation = level.Elevation
            };
        }

        /***************************************************/

        public IObject ToOld(oM.Geometry.SettingOut.Level level)
        {
            if (level == null)
                return null;

            return new oM.Architecture.Elements.Level
            {
                Elevation = level.Elevation
            };
        }

        /***************************************************/
    }
}
