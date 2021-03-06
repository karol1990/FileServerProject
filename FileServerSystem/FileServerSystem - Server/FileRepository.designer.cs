﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FileServerSystemServer
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="FileServerDB")]
	public partial class FileRepositoryDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTOKEN(TOKEN instance);
    partial void UpdateTOKEN(TOKEN instance);
    partial void DeleteTOKEN(TOKEN instance);
    partial void InsertUSER(USER instance);
    partial void UpdateUSER(USER instance);
    partial void DeleteUSER(USER instance);
    #endregion
		
		public FileRepositoryDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["FileServerDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public FileRepositoryDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FileRepositoryDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FileRepositoryDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FileRepositoryDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<FILE> FILEs
		{
			get
			{
				return this.GetTable<FILE>();
			}
		}
		
		public System.Data.Linq.Table<TOKEN> TOKENs
		{
			get
			{
				return this.GetTable<TOKEN>();
			}
		}
		
		public System.Data.Linq.Table<USER> USERs
		{
			get
			{
				return this.GetTable<USER>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[FILE]")]
	public partial class FILE
	{
		
		private string _Login;
		
		private string _File_Length;
		
		private string _File_Data;
		
		private string _File_Name;
		
		private string _File_Extension;
		
		public FILE()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Login", DbType="NVarChar(20)")]
		public string Login
		{
			get
			{
				return this._Login;
			}
			set
			{
				if ((this._Login != value))
				{
					this._Login = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_File_Length", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string File_Length
		{
			get
			{
				return this._File_Length;
			}
			set
			{
				if ((this._File_Length != value))
				{
					this._File_Length = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_File_Data", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string File_Data
		{
			get
			{
				return this._File_Data;
			}
			set
			{
				if ((this._File_Data != value))
				{
					this._File_Data = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_File_Name", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string File_Name
		{
			get
			{
				return this._File_Name;
			}
			set
			{
				if ((this._File_Name != value))
				{
					this._File_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_File_Extension", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string File_Extension
		{
			get
			{
				return this._File_Extension;
			}
			set
			{
				if ((this._File_Extension != value))
				{
					this._File_Extension = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TOKEN")]
	public partial class TOKEN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _UserToken;
		
		private string _Login;
		
		private bool _Is_Active;
		
		private EntityRef<USER> _USER;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserTokenChanging(string value);
    partial void OnUserTokenChanged();
    partial void OnLoginChanging(string value);
    partial void OnLoginChanged();
    partial void OnIs_ActiveChanging(bool value);
    partial void OnIs_ActiveChanged();
    #endregion
		
		public TOKEN()
		{
			this._USER = default(EntityRef<USER>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Token", Storage="_UserToken", DbType="NVarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string UserToken
		{
			get
			{
				return this._UserToken;
			}
			set
			{
				if ((this._UserToken != value))
				{
					this.OnUserTokenChanging(value);
					this.SendPropertyChanging();
					this._UserToken = value;
					this.SendPropertyChanged("UserToken");
					this.OnUserTokenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Login", DbType="NVarChar(20)")]
		public string Login
		{
			get
			{
				return this._Login;
			}
			set
			{
				if ((this._Login != value))
				{
					if (this._USER.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnLoginChanging(value);
					this.SendPropertyChanging();
					this._Login = value;
					this.SendPropertyChanged("Login");
					this.OnLoginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Is_Active", DbType="Bit NOT NULL")]
		public bool Is_Active
		{
			get
			{
				return this._Is_Active;
			}
			set
			{
				if ((this._Is_Active != value))
				{
					this.OnIs_ActiveChanging(value);
					this.SendPropertyChanging();
					this._Is_Active = value;
					this.SendPropertyChanged("Is_Active");
					this.OnIs_ActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="USER_TOKEN", Storage="_USER", ThisKey="Login", OtherKey="Login", IsForeignKey=true)]
		public USER USER
		{
			get
			{
				return this._USER.Entity;
			}
			set
			{
				USER previousValue = this._USER.Entity;
				if (((previousValue != value) 
							|| (this._USER.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._USER.Entity = null;
						previousValue.TOKENs.Remove(this);
					}
					this._USER.Entity = value;
					if ((value != null))
					{
						value.TOKENs.Add(this);
						this._Login = value.Login;
					}
					else
					{
						this._Login = default(string);
					}
					this.SendPropertyChanged("USER");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[USER]")]
	public partial class USER : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Login;
		
		private string _Password;
		
		private EntitySet<TOKEN> _TOKENs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLoginChanging(string value);
    partial void OnLoginChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public USER()
		{
			this._TOKENs = new EntitySet<TOKEN>(new Action<TOKEN>(this.attach_TOKENs), new Action<TOKEN>(this.detach_TOKENs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Login", DbType="NVarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Login
		{
			get
			{
				return this._Login;
			}
			set
			{
				if ((this._Login != value))
				{
					this.OnLoginChanging(value);
					this.SendPropertyChanging();
					this._Login = value;
					this.SendPropertyChanged("Login");
					this.OnLoginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="USER_TOKEN", Storage="_TOKENs", ThisKey="Login", OtherKey="Login")]
		public EntitySet<TOKEN> TOKENs
		{
			get
			{
				return this._TOKENs;
			}
			set
			{
				this._TOKENs.Assign(value);
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
		
		private void attach_TOKENs(TOKEN entity)
		{
			this.SendPropertyChanging();
			entity.USER = this;
		}
		
		private void detach_TOKENs(TOKEN entity)
		{
			this.SendPropertyChanging();
			entity.USER = null;
		}
	}
}
#pragma warning restore 1591
