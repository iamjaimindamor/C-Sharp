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

namespace WindowsFormsApp1
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CompanyDB")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::WindowsFormsApp1.Properties.Settings.Default.CompanyDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employee")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Ename;
		
		private string _EAddress;
		
		private string _EDepartment;
		
		private string _EDesignation;
		
		private System.Nullable<int> _Salary;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnEnameChanging(string value);
    partial void OnEnameChanged();
    partial void OnEAddressChanging(string value);
    partial void OnEAddressChanged();
    partial void OnEDepartmentChanging(string value);
    partial void OnEDepartmentChanged();
    partial void OnEDesignationChanging(string value);
    partial void OnEDesignationChanged();
    partial void OnSalaryChanging(System.Nullable<int> value);
    partial void OnSalaryChanged();
    #endregion
		
		public Employee()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ename", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Ename
		{
			get
			{
				return this._Ename;
			}
			set
			{
				if ((this._Ename != value))
				{
					this.OnEnameChanging(value);
					this.SendPropertyChanging();
					this._Ename = value;
					this.SendPropertyChanged("Ename");
					this.OnEnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EAddress", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string EAddress
		{
			get
			{
				return this._EAddress;
			}
			set
			{
				if ((this._EAddress != value))
				{
					this.OnEAddressChanging(value);
					this.SendPropertyChanging();
					this._EAddress = value;
					this.SendPropertyChanged("EAddress");
					this.OnEAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EDepartment", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string EDepartment
		{
			get
			{
				return this._EDepartment;
			}
			set
			{
				if ((this._EDepartment != value))
				{
					this.OnEDepartmentChanging(value);
					this.SendPropertyChanging();
					this._EDepartment = value;
					this.SendPropertyChanged("EDepartment");
					this.OnEDepartmentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EDesignation", DbType="NChar(25) NOT NULL", CanBeNull=false)]
		public string EDesignation
		{
			get
			{
				return this._EDesignation;
			}
			set
			{
				if ((this._EDesignation != value))
				{
					this.OnEDesignationChanging(value);
					this.SendPropertyChanging();
					this._EDesignation = value;
					this.SendPropertyChanged("EDesignation");
					this.OnEDesignationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Int")]
		public System.Nullable<int> Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this.OnSalaryChanging(value);
					this.SendPropertyChanging();
					this._Salary = value;
					this.SendPropertyChanged("Salary");
					this.OnSalaryChanged();
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
