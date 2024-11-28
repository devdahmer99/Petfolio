using Petfolio.Communication.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petfolio.Communication.Requests;
public class RequestCriaPetJson
{
    public string NomePet { get; set; } = string.Empty;
    public DateTime dataNascimento { get; set; }
    public TipoAnimal Tipo {get; set;}
}
