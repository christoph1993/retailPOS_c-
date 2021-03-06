﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GSHS_POS
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="gshs_pos")]
	public partial class posformconnectionDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertinventory(inventory instance);
    partial void Updateinventory(inventory instance);
    partial void Deleteinventory(inventory instance);
    partial void Inserttransaction(transaction instance);
    partial void Updatetransaction(transaction instance);
    partial void Deletetransaction(transaction instance);
    partial void Insertreciept(reciept instance);
    partial void Updatereciept(reciept instance);
    partial void Deletereciept(reciept instance);
    partial void Insertproduct(product instance);
    partial void Updateproduct(product instance);
    partial void Deleteproduct(product instance);
    partial void InsertinventoryItem(inventoryItem instance);
    partial void UpdateinventoryItem(inventoryItem instance);
    partial void DeleteinventoryItem(inventoryItem instance);
    #endregion
		
		public posformconnectionDataContext() : 
				base(global::GSHS_POS.Properties.Settings.Default.gshs_posConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public posformconnectionDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public posformconnectionDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public posformconnectionDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public posformconnectionDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<inventory> inventories
		{
			get
			{
				return this.GetTable<inventory>();
			}
		}
		
		public System.Data.Linq.Table<transaction> transactions
		{
			get
			{
				return this.GetTable<transaction>();
			}
		}
		
		public System.Data.Linq.Table<reciept> reciepts
		{
			get
			{
				return this.GetTable<reciept>();
			}
		}
		
		public System.Data.Linq.Table<product> products
		{
			get
			{
				return this.GetTable<product>();
			}
		}
		
		public System.Data.Linq.Table<inventoryItem> inventoryItems
		{
			get
			{
				return this.GetTable<inventoryItem>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.inventory")]
	public partial class inventory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _inventoryID;
		
		private System.Nullable<double> _value;
		
		private System.Nullable<int> _itemCount;
		
		private System.Nullable<System.DateTime> _invoiceDate;
		
		private System.Nullable<System.DateTime> _recieveDate;
		
		private EntitySet<inventoryItem> _inventoryItems;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OninventoryIDChanging(string value);
    partial void OninventoryIDChanged();
    partial void OnvalueChanging(System.Nullable<double> value);
    partial void OnvalueChanged();
    partial void OnitemCountChanging(System.Nullable<int> value);
    partial void OnitemCountChanged();
    partial void OninvoiceDateChanging(System.Nullable<System.DateTime> value);
    partial void OninvoiceDateChanged();
    partial void OnrecieveDateChanging(System.Nullable<System.DateTime> value);
    partial void OnrecieveDateChanged();
    #endregion
		
		public inventory()
		{
			this._inventoryItems = new EntitySet<inventoryItem>(new Action<inventoryItem>(this.attach_inventoryItems), new Action<inventoryItem>(this.detach_inventoryItems));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_inventoryID", DbType="Char(36) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string inventoryID
		{
			get
			{
				return this._inventoryID;
			}
			set
			{
				if ((this._inventoryID != value))
				{
					this.OninventoryIDChanging(value);
					this.SendPropertyChanging();
					this._inventoryID = value;
					this.SendPropertyChanged("inventoryID");
					this.OninventoryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_value", DbType="Float")]
		public System.Nullable<double> value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((this._value != value))
				{
					this.OnvalueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("value");
					this.OnvalueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_itemCount", DbType="Int")]
		public System.Nullable<int> itemCount
		{
			get
			{
				return this._itemCount;
			}
			set
			{
				if ((this._itemCount != value))
				{
					this.OnitemCountChanging(value);
					this.SendPropertyChanging();
					this._itemCount = value;
					this.SendPropertyChanged("itemCount");
					this.OnitemCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_invoiceDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> invoiceDate
		{
			get
			{
				return this._invoiceDate;
			}
			set
			{
				if ((this._invoiceDate != value))
				{
					this.OninvoiceDateChanging(value);
					this.SendPropertyChanging();
					this._invoiceDate = value;
					this.SendPropertyChanged("invoiceDate");
					this.OninvoiceDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_recieveDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> recieveDate
		{
			get
			{
				return this._recieveDate;
			}
			set
			{
				if ((this._recieveDate != value))
				{
					this.OnrecieveDateChanging(value);
					this.SendPropertyChanging();
					this._recieveDate = value;
					this.SendPropertyChanged("recieveDate");
					this.OnrecieveDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="inventory_inventoryItem", Storage="_inventoryItems", ThisKey="inventoryID", OtherKey="inventoryID")]
		public EntitySet<inventoryItem> inventoryItems
		{
			get
			{
				return this._inventoryItems;
			}
			set
			{
				this._inventoryItems.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_inventoryItems(inventoryItem entity)
		{
			this.SendPropertyChanging();
			entity.inventory = this;
		}
		
		private void detach_inventoryItems(inventoryItem entity)
		{
			this.SendPropertyChanging();
			entity.inventory = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.transactions")]
	public partial class transaction : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _transactionID;
		
		private System.Nullable<double> _value;
		
		private System.Nullable<int> _items;
		
		private System.Nullable<System.DateTime> _date;
		
		private EntitySet<reciept> _reciepts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntransactionIDChanging(string value);
    partial void OntransactionIDChanged();
    partial void OnvalueChanging(System.Nullable<double> value);
    partial void OnvalueChanged();
    partial void OnitemsChanging(System.Nullable<int> value);
    partial void OnitemsChanged();
    partial void OndateChanging(System.Nullable<System.DateTime> value);
    partial void OndateChanged();
    #endregion
		
		public transaction()
		{
			this._reciepts = new EntitySet<reciept>(new Action<reciept>(this.attach_reciepts), new Action<reciept>(this.detach_reciepts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_transactionID", DbType="Char(36) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string transactionID
		{
			get
			{
				return this._transactionID;
			}
			set
			{
				if ((this._transactionID != value))
				{
					this.OntransactionIDChanging(value);
					this.SendPropertyChanging();
					this._transactionID = value;
					this.SendPropertyChanged("transactionID");
					this.OntransactionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_value", DbType="Float")]
		public System.Nullable<double> value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((this._value != value))
				{
					this.OnvalueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("value");
					this.OnvalueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_items", DbType="Int")]
		public System.Nullable<int> items
		{
			get
			{
				return this._items;
			}
			set
			{
				if ((this._items != value))
				{
					this.OnitemsChanging(value);
					this.SendPropertyChanging();
					this._items = value;
					this.SendPropertyChanged("items");
					this.OnitemsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="DateTime")]
		public System.Nullable<System.DateTime> date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="transaction_reciept", Storage="_reciepts", ThisKey="transactionID", OtherKey="transactionID")]
		public EntitySet<reciept> reciepts
		{
			get
			{
				return this._reciepts;
			}
			set
			{
				this._reciepts.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_reciepts(reciept entity)
		{
			this.SendPropertyChanging();
			entity.transaction = this;
		}
		
		private void detach_reciepts(reciept entity)
		{
			this.SendPropertyChanging();
			entity.transaction = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.reciept")]
	public partial class reciept : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _transactionID;
		
		private int _productID;
		
		private System.Nullable<int> _quantity;
		
		private EntityRef<transaction> _transaction;
		
		private EntityRef<product> _product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntransactionIDChanging(string value);
    partial void OntransactionIDChanged();
    partial void OnproductIDChanging(int value);
    partial void OnproductIDChanged();
    partial void OnquantityChanging(System.Nullable<int> value);
    partial void OnquantityChanged();
    #endregion
		
		public reciept()
		{
			this._transaction = default(EntityRef<transaction>);
			this._product = default(EntityRef<product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_transactionID", DbType="Char(36) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string transactionID
		{
			get
			{
				return this._transactionID;
			}
			set
			{
				if ((this._transactionID != value))
				{
					if (this._transaction.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OntransactionIDChanging(value);
					this.SendPropertyChanging();
					this._transactionID = value;
					this.SendPropertyChanged("transactionID");
					this.OntransactionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int productID
		{
			get
			{
				return this._productID;
			}
			set
			{
				if ((this._productID != value))
				{
					if (this._product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnproductIDChanging(value);
					this.SendPropertyChanging();
					this._productID = value;
					this.SendPropertyChanged("productID");
					this.OnproductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantity", DbType="Int")]
		public System.Nullable<int> quantity
		{
			get
			{
				return this._quantity;
			}
			set
			{
				if ((this._quantity != value))
				{
					this.OnquantityChanging(value);
					this.SendPropertyChanging();
					this._quantity = value;
					this.SendPropertyChanged("quantity");
					this.OnquantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="transaction_reciept", Storage="_transaction", ThisKey="transactionID", OtherKey="transactionID", IsForeignKey=true)]
		public transaction transaction
		{
			get
			{
				return this._transaction.Entity;
			}
			set
			{
				transaction previousValue = this._transaction.Entity;
				if (((previousValue != value) 
							|| (this._transaction.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._transaction.Entity = null;
						previousValue.reciepts.Remove(this);
					}
					this._transaction.Entity = value;
					if ((value != null))
					{
						value.reciepts.Add(this);
						this._transactionID = value.transactionID;
					}
					else
					{
						this._transactionID = default(string);
					}
					this.SendPropertyChanged("transaction");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="product_reciept", Storage="_product", ThisKey="productID", OtherKey="productID", IsForeignKey=true)]
		public product product
		{
			get
			{
				return this._product.Entity;
			}
			set
			{
				product previousValue = this._product.Entity;
				if (((previousValue != value) 
							|| (this._product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._product.Entity = null;
						previousValue.reciepts.Remove(this);
					}
					this._product.Entity = value;
					if ((value != null))
					{
						value.reciepts.Add(this);
						this._productID = value.productID;
					}
					else
					{
						this._productID = default(int);
					}
					this.SendPropertyChanged("product");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.products")]
	public partial class product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _productID;
		
		private string _size;
		
		private System.Nullable<char> _gender;
		
		private string _category;
		
		private string _style;
		
		private System.Nullable<bool> _second_hand;
		
		private System.Nullable<int> _inStock;
		
		private System.Nullable<double> _cost;
		
		private System.Nullable<long> _code;
		
		private EntitySet<reciept> _reciepts;
		
		private EntitySet<inventoryItem> _inventoryItems;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnproductIDChanging(int value);
    partial void OnproductIDChanged();
    partial void OnsizeChanging(string value);
    partial void OnsizeChanged();
    partial void OngenderChanging(System.Nullable<char> value);
    partial void OngenderChanged();
    partial void OncategoryChanging(string value);
    partial void OncategoryChanged();
    partial void OnstyleChanging(string value);
    partial void OnstyleChanged();
    partial void Onsecond_handChanging(System.Nullable<bool> value);
    partial void Onsecond_handChanged();
    partial void OninStockChanging(System.Nullable<int> value);
    partial void OninStockChanged();
    partial void OncostChanging(System.Nullable<double> value);
    partial void OncostChanged();
    partial void OncodeChanging(System.Nullable<long> value);
    partial void OncodeChanged();
    #endregion
		
		public product()
		{
			this._reciepts = new EntitySet<reciept>(new Action<reciept>(this.attach_reciepts), new Action<reciept>(this.detach_reciepts));
			this._inventoryItems = new EntitySet<inventoryItem>(new Action<inventoryItem>(this.attach_inventoryItems), new Action<inventoryItem>(this.detach_inventoryItems));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int productID
		{
			get
			{
				return this._productID;
			}
			set
			{
				if ((this._productID != value))
				{
					this.OnproductIDChanging(value);
					this.SendPropertyChanging();
					this._productID = value;
					this.SendPropertyChanged("productID");
					this.OnproductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_size", DbType="VarChar(4)")]
		public string size
		{
			get
			{
				return this._size;
			}
			set
			{
				if ((this._size != value))
				{
					this.OnsizeChanging(value);
					this.SendPropertyChanging();
					this._size = value;
					this.SendPropertyChanged("size");
					this.OnsizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gender", DbType="Char(1)")]
		public System.Nullable<char> gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if ((this._gender != value))
				{
					this.OngenderChanging(value);
					this.SendPropertyChanging();
					this._gender = value;
					this.SendPropertyChanged("gender");
					this.OngenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_category", DbType="VarChar(16)")]
		public string category
		{
			get
			{
				return this._category;
			}
			set
			{
				if ((this._category != value))
				{
					this.OncategoryChanging(value);
					this.SendPropertyChanging();
					this._category = value;
					this.SendPropertyChanged("category");
					this.OncategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_style", DbType="VarChar(16)")]
		public string style
		{
			get
			{
				return this._style;
			}
			set
			{
				if ((this._style != value))
				{
					this.OnstyleChanging(value);
					this.SendPropertyChanging();
					this._style = value;
					this.SendPropertyChanged("style");
					this.OnstyleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_second_hand", DbType="Bit")]
		public System.Nullable<bool> second_hand
		{
			get
			{
				return this._second_hand;
			}
			set
			{
				if ((this._second_hand != value))
				{
					this.Onsecond_handChanging(value);
					this.SendPropertyChanging();
					this._second_hand = value;
					this.SendPropertyChanged("second_hand");
					this.Onsecond_handChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_inStock", DbType="Int")]
		public System.Nullable<int> inStock
		{
			get
			{
				return this._inStock;
			}
			set
			{
				if ((this._inStock != value))
				{
					this.OninStockChanging(value);
					this.SendPropertyChanging();
					this._inStock = value;
					this.SendPropertyChanged("inStock");
					this.OninStockChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cost", DbType="Float")]
		public System.Nullable<double> cost
		{
			get
			{
				return this._cost;
			}
			set
			{
				if ((this._cost != value))
				{
					this.OncostChanging(value);
					this.SendPropertyChanging();
					this._cost = value;
					this.SendPropertyChanged("cost");
					this.OncostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_code", DbType="BigInt")]
		public System.Nullable<long> code
		{
			get
			{
				return this._code;
			}
			set
			{
				if ((this._code != value))
				{
					this.OncodeChanging(value);
					this.SendPropertyChanging();
					this._code = value;
					this.SendPropertyChanged("code");
					this.OncodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="product_reciept", Storage="_reciepts", ThisKey="productID", OtherKey="productID")]
		public EntitySet<reciept> reciepts
		{
			get
			{
				return this._reciepts;
			}
			set
			{
				this._reciepts.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="product_inventoryItem", Storage="_inventoryItems", ThisKey="productID", OtherKey="productID")]
		public EntitySet<inventoryItem> inventoryItems
		{
			get
			{
				return this._inventoryItems;
			}
			set
			{
				this._inventoryItems.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_reciepts(reciept entity)
		{
			this.SendPropertyChanging();
			entity.product = this;
		}
		
		private void detach_reciepts(reciept entity)
		{
			this.SendPropertyChanging();
			entity.product = null;
		}
		
		private void attach_inventoryItems(inventoryItem entity)
		{
			this.SendPropertyChanging();
			entity.product = this;
		}
		
		private void detach_inventoryItems(inventoryItem entity)
		{
			this.SendPropertyChanging();
			entity.product = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.inventoryItems")]
	public partial class inventoryItem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _inventoryID;
		
		private int _productID;
		
		private System.Nullable<int> _quantity;
		
		private EntityRef<inventory> _inventory;
		
		private EntityRef<product> _product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OninventoryIDChanging(string value);
    partial void OninventoryIDChanged();
    partial void OnproductIDChanging(int value);
    partial void OnproductIDChanged();
    partial void OnquantityChanging(System.Nullable<int> value);
    partial void OnquantityChanged();
    #endregion
		
		public inventoryItem()
		{
			this._inventory = default(EntityRef<inventory>);
			this._product = default(EntityRef<product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_inventoryID", DbType="Char(36) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string inventoryID
		{
			get
			{
				return this._inventoryID;
			}
			set
			{
				if ((this._inventoryID != value))
				{
					if (this._inventory.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OninventoryIDChanging(value);
					this.SendPropertyChanging();
					this._inventoryID = value;
					this.SendPropertyChanged("inventoryID");
					this.OninventoryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int productID
		{
			get
			{
				return this._productID;
			}
			set
			{
				if ((this._productID != value))
				{
					if (this._product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnproductIDChanging(value);
					this.SendPropertyChanging();
					this._productID = value;
					this.SendPropertyChanged("productID");
					this.OnproductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantity", DbType="Int")]
		public System.Nullable<int> quantity
		{
			get
			{
				return this._quantity;
			}
			set
			{
				if ((this._quantity != value))
				{
					this.OnquantityChanging(value);
					this.SendPropertyChanging();
					this._quantity = value;
					this.SendPropertyChanged("quantity");
					this.OnquantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="inventory_inventoryItem", Storage="_inventory", ThisKey="inventoryID", OtherKey="inventoryID", IsForeignKey=true)]
		public inventory inventory
		{
			get
			{
				return this._inventory.Entity;
			}
			set
			{
				inventory previousValue = this._inventory.Entity;
				if (((previousValue != value) 
							|| (this._inventory.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._inventory.Entity = null;
						previousValue.inventoryItems.Remove(this);
					}
					this._inventory.Entity = value;
					if ((value != null))
					{
						value.inventoryItems.Add(this);
						this._inventoryID = value.inventoryID;
					}
					else
					{
						this._inventoryID = default(string);
					}
					this.SendPropertyChanged("inventory");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="product_inventoryItem", Storage="_product", ThisKey="productID", OtherKey="productID", IsForeignKey=true)]
		public product product
		{
			get
			{
				return this._product.Entity;
			}
			set
			{
				product previousValue = this._product.Entity;
				if (((previousValue != value) 
							|| (this._product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._product.Entity = null;
						previousValue.inventoryItems.Remove(this);
					}
					this._product.Entity = value;
					if ((value != null))
					{
						value.inventoryItems.Add(this);
						this._productID = value.productID;
					}
					else
					{
						this._productID = default(int);
					}
					this.SendPropertyChanged("product");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
