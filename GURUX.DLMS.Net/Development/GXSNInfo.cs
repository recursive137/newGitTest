//
// --------------------------------------------------------------------------
//  Gurux Ltd
// 
//
//
// Filename:        $HeadURL$
//
// Version:         $Revision$,
//                  $Date$
//                  $Author$
//
// Copyright (c) Gurux Ltd
//
//---------------------------------------------------------------------------
//
//  DESCRIPTION
//
// This file is a part of Gurux Device Framework.
//
// Gurux Device Framework is Open Source software; you can redistribute it
// and/or modify it under the terms of the GNU General Public License 
// as published by the Free Software Foundation; version 2 of the License.
// Gurux Device Framework is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of 
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. 
// See the GNU General Public License for more details.
//
// More information of Gurux products: http://www.gurux.org
//
// This code is licensed under the GNU General Public License v2. 
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------

namespace Gurux.DLMS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Gurux.DLMS.Objects;

    ///<summary>
    ///Server uses this class to find Short Name object and attribute index. 
    ///This class is reserved for internal use.
    ///</summary>
    class GXSNInfo
    {
        /// <summary>
        /// Attribute index.
        /// </summary>
        public virtual int Index
        {
            get;
            set;
        }

        /// <summary>
        /// Is attribute index or action index 
        /// </summary>
        public virtual bool IsAction
        {
            get;
            set;
        }

        /// <summary>
        /// COSEM object.
        /// </summary>
        public virtual GXDLMSObject Item
        {
            get;
            set;
        }
    }
}