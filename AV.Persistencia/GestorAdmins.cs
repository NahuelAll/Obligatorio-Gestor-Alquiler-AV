using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using AV.Entities;
namespace AV.Persistencia
{
    public class GestorAdmins
    {
        public static void GuardarRegistroAdmin(List<Administrador> listaAdmin)
        {
            const string PATH = "D:\\Temporal\\library.files\\admin.json";
            var json = JsonSerializer.Serialize(listaAdmin);
            File.WriteAllText(PATH, json);
        }

        public static List<Administrador> LeerAdmin()
        {
            const string PATH = "D:\\Temporal\\library.files\\admin.json";
            string content;
            if (!File.Exists(PATH))
                return null;
            else
                content = File.ReadAllText(PATH);
            List<Administrador> admin = JsonSerializer.Deserialize<List<Administrador>>(content) ?? [];
            return admin;
        }
    }
}
