﻿// 
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
using backup.core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

/**
 * Description:
 * This interface defines operations for manipulating 'replay log' entities in an Azure Storage Table.
 * 
 * Author: GR @Microsoft
 * Dated: 05-23-2020
 *
 * NOTES: Capture updates to the code below.
 */
namespace backup.core.Interfaces
{
    /// <summary>
    /// Repository to store the back up (replay) logs.
    /// This interface contains methods to store and read the backup logs entities.
    /// </summary>
    public interface ILogTableRepository
    {
        /// <summary>
        /// Inserts the blob event in Az storage table
        /// </summary>
        /// <param name="blobEvent"></param>
        /// <returns></returns>
        Task InsertBLOBEvent(IEventData eventData);

        /// <summary>
        /// Returns the blob event entities from Az storage table based on yearNumber, weeknumber, start date and 
	/// end date
        /// </summary>
        /// <param name="yearNumber"></param>
        /// <param name="weekNumber"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns>A list of blob events from the replay log table</returns>
        Task<List<IEventData>> GetBLOBEvents(int yearNumber,int weekNumber, DateTime startDate, DateTime endDate);
    }
}
