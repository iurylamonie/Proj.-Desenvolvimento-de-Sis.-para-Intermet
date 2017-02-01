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
    partial void InsertUsuario(Usuario instance);
    partial void UpdateUsuario(Usuario instance);
    partial void DeleteUsuario(Usuario instance);
    partial void InsertGrupoUsuario(GrupoUsuario instance);
    partial void UpdateGrupoUsuario(GrupoUsuario instance);
    partial void DeleteGrupoUsuario(GrupoUsuario instance);
    partial void InsertGrupo(Grupo instance);
    partial void UpdateGrupo(Grupo instance);
    partial void DeleteGrupo(Grupo instance);
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
		
		public System.Data.Linq.Table<Grupo> Grupos
		{
			get
			{
				return this.GetTable<Grupo>();
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
		
		private System.Data.Linq.Binary _foto;
		
		private EntitySet<GrupoUsuario> _GrupoUsuarios;
		
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
    partial void OnfotoChanging(System.Data.Linq.Binary value);
    partial void OnfotoChanged();
    #endregion
		
		public Usuario()
		{
			this._GrupoUsuarios = new EntitySet<GrupoUsuario>(new Action<GrupoUsuario>(this.attach_GrupoUsuarios), new Action<GrupoUsuario>(this.detach_GrupoUsuarios));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_foto", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary foto
		{
			get
			{
				return this._foto;
			}
			set
			{
				if ((this._foto != value))
				{
					this.OnfotoChanging(value);
					this.SendPropertyChanging();
					this._foto = value;
					this.SendPropertyChanged("foto");
					this.OnfotoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_GrupoUsuario", Storage="_GrupoUsuarios", ThisKey="id", OtherKey="usuario_id")]
		public EntitySet<GrupoUsuario> GrupoUsuarios
		{
			get
			{
				return this._GrupoUsuarios;
			}
			set
			{
				this._GrupoUsuarios.Assign(value);
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
		
		private void attach_GrupoUsuarios(GrupoUsuario entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = this;
		}
		
		private void detach_GrupoUsuarios(GrupoUsuario entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GrupoUsuario")]
	public partial class GrupoUsuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _usuario_id;
		
		private int _grupo_id;
		
		private EntityRef<Usuario> _Usuario;
		
		private EntityRef<Grupo> _Grupo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onusuario_idChanging(int value);
    partial void Onusuario_idChanged();
    partial void Ongrupo_idChanging(int value);
    partial void Ongrupo_idChanged();
    #endregion
		
		public GrupoUsuario()
		{
			this._Usuario = default(EntityRef<Usuario>);
			this._Grupo = default(EntityRef<Grupo>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usuario_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int usuario_id
		{
			get
			{
				return this._usuario_id;
			}
			set
			{
				if ((this._usuario_id != value))
				{
					if (this._Usuario.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onusuario_idChanging(value);
					this.SendPropertyChanging();
					this._usuario_id = value;
					this.SendPropertyChanged("usuario_id");
					this.Onusuario_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_grupo_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int grupo_id
		{
			get
			{
				return this._grupo_id;
			}
			set
			{
				if ((this._grupo_id != value))
				{
					if (this._Grupo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Ongrupo_idChanging(value);
					this.SendPropertyChanging();
					this._grupo_id = value;
					this.SendPropertyChanged("grupo_id");
					this.Ongrupo_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_GrupoUsuario", Storage="_Usuario", ThisKey="usuario_id", OtherKey="id", IsForeignKey=true)]
		public Usuario Usuario
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
						previousValue.GrupoUsuarios.Remove(this);
					}
					this._Usuario.Entity = value;
					if ((value != null))
					{
						value.GrupoUsuarios.Add(this);
						this._usuario_id = value.id;
					}
					else
					{
						this._usuario_id = default(int);
					}
					this.SendPropertyChanged("Usuario");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Grupo_GrupoUsuario", Storage="_Grupo", ThisKey="grupo_id", OtherKey="id", IsForeignKey=true)]
		public Grupo Grupo
		{
			get
			{
				return this._Grupo.Entity;
			}
			set
			{
				Grupo previousValue = this._Grupo.Entity;
				if (((previousValue != value) 
							|| (this._Grupo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Grupo.Entity = null;
						previousValue.GrupoUsuarios.Remove(this);
					}
					this._Grupo.Entity = value;
					if ((value != null))
					{
						value.GrupoUsuarios.Add(this);
						this._grupo_id = value.id;
					}
					else
					{
						this._grupo_id = default(int);
					}
					this.SendPropertyChanged("Grupo");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Grupo")]
	public partial class Grupo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _descricao;
		
		private System.Nullable<int> _idAdm;
		
		private EntitySet<GrupoUsuario> _GrupoUsuarios;
		
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
			this._GrupoUsuarios = new EntitySet<GrupoUsuario>(new Action<GrupoUsuario>(this.attach_GrupoUsuarios), new Action<GrupoUsuario>(this.detach_GrupoUsuarios));
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
					this.OnidAdmChanging(value);
					this.SendPropertyChanging();
					this._idAdm = value;
					this.SendPropertyChanged("idAdm");
					this.OnidAdmChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Grupo_GrupoUsuario", Storage="_GrupoUsuarios", ThisKey="id", OtherKey="grupo_id")]
		public EntitySet<GrupoUsuario> GrupoUsuarios
		{
			get
			{
				return this._GrupoUsuarios;
			}
			set
			{
				this._GrupoUsuarios.Assign(value);
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
		
		private void attach_GrupoUsuarios(GrupoUsuario entity)
		{
			this.SendPropertyChanging();
			entity.Grupo = this;
		}
		
		private void detach_GrupoUsuarios(GrupoUsuario entity)
		{
			this.SendPropertyChanging();
			entity.Grupo = null;
		}
	}
}
#pragma warning restore 1591
