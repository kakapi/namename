/***********************************************************************
 * Module:  Shop_SellDetail.cs
 * Author:  Administrator
 * Purpose: Definition of the Class Shop_SellDetail
 ***********************************************************************/

using System;

public class Shop_SellDetail
{
   private int _ID;
   private string _BillNO;
   private Guid _��Ʒid;
   private string _��λ;
   private decimal _����;
   private decimal _����;

   public int ID
   {
      get
      {
         return _ID;
      }
      set
      {
         if (this._ID != value)
            this._ID = value;
      }
   }
   
   public string BillNO
   {
      get
      {
         return _BillNO;
      }
      set
      {
         if (this._BillNO != value)
            this._BillNO = value;
      }
   }
   
   public Guid ��Ʒid
   {
      get
      {
         return _��Ʒid;
      }
      set
      {
         if (this._��Ʒid != value)
            this._��Ʒid = value;
      }
   }
   
   public string ��λ
   {
      get
      {
         return _��λ;
      }
      set
      {
         if (this._��λ != value)
            this._��λ = value;
      }
   }
   
   public decimal ����
   {
      get
      {
         return _����;
      }
      set
      {
         if (this._���� != value)
            this._���� = value;
      }
   }
   
   public decimal ����
   {
      get
      {
         return _����;
      }
      set
      {
         if (this._���� != value)
            this._���� = value;
      }
   }

}