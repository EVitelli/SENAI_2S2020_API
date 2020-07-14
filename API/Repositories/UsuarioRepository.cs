using API.Controllers;
using API.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace API.Repositories
{
    public class UsuarioRepository
    {
        private static List<Usuarios> usuarios;
        private static int contador = 1;

        public UsuarioRepository()
        {
            if (usuarios == null)
            {
                usuarios = new List<Usuarios>
                {
                    new Usuarios
                    {
                        Id = contador,
                        Nome = "Erik Vitelli",
                        Email = "erik.vitelli@email.com",
                        Senha = "123456"
                    }
                };
                contador++;
            }
        }

        public void add(Usuarios usuario)
        {
            contador++;
            usuario.Id = contador;
            usuarios.Add(usuario);
        }

        public void edit(Usuarios usuario)
        {
            int position = usuarios.IndexOf(usuario);

            usuarios[position].Nome = usuario.Nome;
            usuarios[position].Email = usuario.Email;
            usuarios[position].Senha = usuario.Senha;
        }

        public Usuarios buscarPorEmailSenha(LoginViewModel loginViewModel)
        {
            return usuarios.FirstOrDefault(
                x => x.Email == loginViewModel.email && x.Senha == loginViewModel.senha);
        }
    }
}
