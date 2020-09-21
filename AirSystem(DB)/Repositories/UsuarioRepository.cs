using AirSystem.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSystem.Repositories
{
      public class UsuarioRepository
    {
        

      
        public UsuarioRepository()
        {
            //if (usuarios == null)
            //{
            //    usuarios = new List<Usuario> { 
            //        new Usuario
            //        {
            //            codigo = 0,
            //            nome = "Thiago",
            //            sobrenome = "Henrique",
            //            endereco = "Rua das Margaridas",
            //            numeroEnd = "207",
            //            usuario = "MajorHenri",
            //            senha = "Thiago123",
            //            tipousuario = "false"
            //        }
            //    };
            //}
        }
        public List<Usuarios> BuscarTodos()
        {
            using (AirSystemEntities ent = new AirSystemEntities())
            {
                return ent.Usuarios.
                ToList();
            }
        }

        public void Adicionar(Usuarios usuario)
        {
            using (AirSystemEntities ent = new AirSystemEntities())
            {
                ent.Usuarios.Add(usuario);
                ent.SaveChanges();
            }
        }

        public Usuarios BuscarUsuarioPorLogin(string usuario, string password)
        {
            using (var ent = new AirSystemEntities())
            {
                Usuarios us = ent.Usuarios.FirstOrDefault(u => u.Tx_Usuario == usuario && u.Tx_Senha == password);

                return us;
            }
        }
        //public Usuarios BuscarUsuarioPorLogin(Usuarios user)
        //{
        //    using (var ent = new AirSystemEntities())
        //    {
        //        user = ent.Usuarios.FirstOrDefault(u => u.Tx_Usuario == user.Tx_Usuario && u.Tx_Senha == user.Tx_Senha);

        //        return user;
        //    }
        //}
        public void Editar(Usuarios usuario)
        {
            using (AirSystemEntities ent = new AirSystemEntities())
            {
                Usuarios u = ent.Usuarios.FirstOrDefault(x => x.Id == usuario.Id);
                if (u != null)
                {
                    u.Tx_Nome = usuario.Tx_Nome;
                    u.Tx_Sobrenome = usuario.Tx_Sobrenome;
                    u.Tx_Logradouro = usuario.Tx_Logradouro;
                    u.Nr_Casa = usuario.Nr_Casa;
                    u.Dt_Nascimento = usuario.Dt_Nascimento;
                    u.Tx_Usuario = usuario.Tx_Usuario;
                    u.Tx_Senha = usuario.Tx_Senha;
                    u.IsAdmin = usuario.IsAdmin;
                    ent.SaveChanges();
                }
            }

        }

        public void Deletar(int id)
        {
            using (AirSystemEntities ent = new AirSystemEntities())
            {
                Usuarios usuario = ent.Usuarios.FirstOrDefault(x => x.Id == id);
                if(usuario != null)
                {
                    ent.Usuarios.Remove(usuario);
                    ent.SaveChanges();
                }
            }
        }

        public bool UsuarioExiste(string usuario)
        {
            using (AirSystemEntities ent = new AirSystemEntities())
            {
                if (ent.Usuarios.FirstOrDefault(x => x.Tx_Usuario == usuario) == null)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
