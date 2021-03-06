/***********************************************************************
 * Module:  AreaInfo.cs
 * Author:  Administrator
 * Purpose: Definition of the Class AreaInfo
 ***********************************************************************/

using System;
using SubSonic.SqlGeneration.Schema;
namespace NameName.Model
{public class AreaInfo
{
   private Guid _AreaID;
   private string _AreaName;
   private bool _DeleteFlag;

   [SubSonicPrimaryKey]
   public Guid AreaID
   {
      get
      {
         return _AreaID;
      }
      set
      {
         if (this._AreaID != value)
            this._AreaID = value;
      }
   }

   public string AreaName
   {
      get
      {
         return _AreaName;
      }
      set
      {
         if (this._AreaName != value)
            this._AreaName = value;
      }
   }
   
   public bool DeleteFlag
   {
      get
      {
         return _DeleteFlag;
      }
      set
      {
         if (this._DeleteFlag != value)
            this._DeleteFlag = value;
      }
   }

} }
