﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sdl.Community.GroupShareKit.Clients
{
    public class CreateProjectRequest
    {
        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the raw data.
        /// </summary>
        /// <value>
        /// The raw data.
        /// </value>
        public byte[] RawData { get; set; }

        /// <summary>
        /// Gets or sets the organization id.
        /// </summary>
        /// <value>
        /// The organization id.
        /// </value>
        public string OrganizationId { get; set; }

        public string  Description   { get; set; }
        public DateTime? DueDate { get; set; }
        public string ProjectTemplateId { get; set; }

        public CreateProjectRequest(string fileName,
            string organizationId,
            byte[] rawData)
        {
            Name = fileName;
            OrganizationId = organizationId;
            RawData = rawData;
        }

        public CreateProjectRequest(string fileName, string organizationId, byte[] rawData,
            string description, DateTime dueDate, string projectTemplateId) : this(fileName, organizationId, rawData)
        {
            Description = description;
            DueDate = dueDate;
            ProjectTemplateId = projectTemplateId;
        }
    }
}
