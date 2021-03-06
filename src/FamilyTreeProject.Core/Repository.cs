﻿//******************************************
//  Copyright (C) 2014-2015 Charles Nurse  *
//                                         *
//  Licensed under MIT License             *
//  (see included LICENSE)                 *
//                                         *
// *****************************************

using FamilyTreeProject.Common;

namespace FamilyTreeProject
{
    /// <summary>
    /// The Repository class represents a repository of Family Tree information (this could be a website or a library for example)
    /// </summary>
    public class Repository : Entity
    {
        public Repository() : base(-1) { }

        public Repository(int treeId) : base(treeId) { }

        /// <summary>
        /// The Address of the Repository
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// The Name of the Repository
        /// </summary>
        public string Name { get; set; }
    }
}
