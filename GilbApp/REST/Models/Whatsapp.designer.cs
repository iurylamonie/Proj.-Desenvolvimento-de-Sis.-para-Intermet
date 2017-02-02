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

namespace REST.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="20131011110169")]
	public partial class WhatsappDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertGrupo(Grupo instance);
    partial void UpdateGrupo(Grupo instance);
    partial void DeleteGrupo(Grupo instance);
    partial void InsertUsuario(Usuario instance);
    partial void UpdateUsuario(Usuario instance);
    partial void DeleteUsuario(Usuario instance);
    #endregion
		
		public WhatsappDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["_20131011110169ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public WhatsappDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WhatsappDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WhatsappDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WhatsappDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Grupo> Grupos
		{
			get
			{
				return this.GetTable<Grupo>();
			}
		}
		
		public System.Data.Linq.Table<Usuario> Usuarios
		{
			get
			{
				return this.GetTable<Usuario>();
			}
		}
		
		public System.Data.Linq.Table<GrupoUsuario> GrupoUsuarios
		{
			get
			{
				return this.GetTable<GrupoUsuario>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Grupo")]
	public partial class Grupo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _descricao;
		
		private System.Nullable<int> _idAdm;
		
		private EntityRef<Usuario> _Usuario;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OndescricaoChanging(string value);
    partial void OndescricaoChanged();
    partial void OnidAdmChanging(System.Nullable<int> value);
    partial void OnidAdmChanged();
    #endregion
		
		public Grupo()
		{
			this._Usuario = default(EntityRef<Usuario>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descricao", DbType="VarChar(MAX)")]
		public string descricao
		{
			get
			{
				return this._descricao;
			}
			set
			{
				if ((this._descricao != value))
				{
					this.OndescricaoChanging(value);
					this.SendPropertyChanging();
					this._descricao = value;
					this.SendPropertyChanged("descricao");
					this.OndescricaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idAdm", DbType="Int")]
		public System.Nullable<int> idAdm
		{
			get
			{
				return this._idAdm;
			}
			set
			{
				if ((this._idAdm != value))
				{
					if (this._Usuario.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidAdmChanging(value);
					this.SendPropertyChanging();
					this._idAdm = value;
					this.SendPropertyChanged("idAdm");
					this.OnidAdmChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_Grupo", Storage="_Usuario", ThisKey="idAdm", OtherKey="id", IsForeignKey=true)]
		internal Usuario Usuario
		{
			get
			{
				return this._Usuario.Entity;
			}
			set
			{
				Usuario previousValue = this._Usuario.Entity;
				if (((previousValue != value) 
							|| (this._Usuario.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Usuario.Entity = null;
						previousValue.Grupos.Remove(this);
					}
					this._Usuario.Entity = value;
					if ((value != null))
					{
						value.Grupos.Add(this);
						this._idAdm = value.id;
					}
					else
					{
						this._idAdm = default(Nullable<int>);
					}
					this.SendPropertyChanged("Usuario");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Usuario")]
	public partial class Usuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _nome;
		
		private string _uri;
		
		private EntitySet<Grupo> _Grupos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnomeChanging(string value);
    partial void OnnomeChanged();
    partial void OnuriChanging(string value);
    partial void OnuriChanged();
    #endregion
		
		public Usuario()
		{
			this._Grupos = new EntitySet<Grupo>(new Action<Grupo>(this.attach_Grupos), new Action<Grupo>(this.detach_Grupos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nome", DbType="VarChar(MAX)")]
		public string nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if ((this._nome != value))
				{
					this.OnnomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("nome");
					this.OnnomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uri", DbType="VarChar(MAX)")]
		public string uri
		{
			get
			{
				return this._uri;
			}
			set
			{
				if ((this._uri != value))
				{
					this.OnuriChanging(value);
					this.SendPropertyChanging();
					this._uri = value;
					this.SendPropertyChanged("uri");
					this.OnuriChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_Grupo", Storage="_Grupos", ThisKey="id", OtherKey="idAdm")]
		public EntitySet<Grupo> Grupos
		{
			get
			{
				return this._Grupos;
			}
			set
			{
				this._Grupos.Assign(value);
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
		
		private void attach_Grupos(Grupo entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = this;
		}
		
		private void detach_Grupos(Grupo entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GrupoUsuario")]
	public partial class GrupoUsuario
	{
		
		private System.Nullable<int> _grupo_id;
		
		private System.Nullable<int> _usuario_id;
		
		public GrupoUsuario()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_grupo_id", DbType="Int")]
		public System.Nullable<int> grupo_id
		{
			get
			{
				return this._grupo_id;
			}
			set
			{
				if ((this._grupo_id != value))
				{
					this._grupo_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usuario_id", DbType="Int")]
		public System.Nullable<int> usuario_id
		{
			get
			{
				return this._usuario_id;
			}
			set
			{
				if ((this._usuario_id != value))
				{
					this._usuario_id = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
