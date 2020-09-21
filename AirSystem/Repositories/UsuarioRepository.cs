using AirSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSystem.Repositories
{
      public class UsuarioRepository
    {
        private static List<Usuario> usuarios;

        private static int contador = 1;
        public UsuarioRepository()
        {
            if (usuarios == null)
            {
                usuarios = new List<Usuario> {
                    new Usuario
                    {
                        codigo = 0,
                        nome = "Thiago",
                        sobrenome = "Henrique",
                        endereco = "Rua das Margaridas",
                        numeroEnd = "207",
                        nascimento = DateTime.Now,
                        usuario = "MajorHenri",
                        senha = "Thiago123",
                        tipousuario = true
                    },
                    new Usuario
                    {
                        codigo = 1,
                        nome = "Teste",
                        sobrenome = "1,2,3",
                        endereco = "Av testatora",
                        numeroEnd = "123",
                        nascimento = DateTime.Now,
                        usuario = "Teste123",
                        senha = "Testando123",
                        tipousuario = false

                    }
                };
                
            }
        }
        public List<Usuario> BuscarTodos()
        {
            return usuarios.ToList();
        }

        public void Adicionar(Usuario usuario)
        {
            usuario.codigo = contador;
            usuarios.Add(usuario);
            contador++;
        }

        public void Editar(Usuario usuario)
        {
            Usuario u = usuarios.FirstOrDefault(x => x.codigo == usuario.codigo);
            usuarios[usuarios.IndexOf(u)] = usuario;

            u.nome = usuario.nome;
            u.sobrenome = usuario.sobrenome;
            u.endereco = usuario.endereco;
            u.numeroEnd = usuario.numeroEnd;
            u.usuario = usuario.usuario;
            u.senha = usuario.senha;
            u.tipousuario = usuario.tipousuario;

        }

        public void Deletar(int codigo)
        {
            Usuario usuario = usuarios.Find(x => x.codigo == codigo);
            usuarios.Remove(usuario);
        }

        public Usuario BuscarPorLogin(string user, string password)
        {
            Usuario us = usuarios.FirstOrDefault(x => x.usuario == user && x.senha == password );

            return us;
        }

        public bool UsuarioExiste(string usuario)
        {
            if (usuarios.FirstOrDefault(x=>x.usuario ==usuario) == null)
            {
                return true;
            }

            return false;
        }
    }
}
