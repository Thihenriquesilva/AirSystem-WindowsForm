using AirSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSystem.Repositories
{
      class UsuarioRepository
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
                        usuario = "MajorHenri",
                        senha = "Thiago123",
                        tipousuario = "false"
                    }
                };
            }
        }
        public List<Usuario> BuscarTodos()
        {
            return usuarios;
        }

        public void Adicionar(Usuario usuario)
        {
            usuario.codigo = contador;
            usuarios.Add(usuario);
            contador++;
        }

        public void Editar(Usuario usuario)
        {
            Usuario u = usuarios.Find(x => x.codigo == usuario.codigo);
            usuarios[usuarios.IndexOf(u)] = usuario;

            u.nome = usuario.nome;
            u.sobrenome = usuario.sobrenome;
            u.endereco = usuario.endereco;
            u.numeroEnd = usuario.numeroEnd;
            u.usuario = usuario.usuario;
            u.senha = u.senha;

        }

        public void Deletar(int codigo)
        {
            Usuario usuario = usuarios.Find(x => x.codigo == codigo);
            usuarios.Remove(usuario);
        }
    }
}
