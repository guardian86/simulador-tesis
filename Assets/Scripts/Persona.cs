using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persona : MonoBehaviour
{
    public CondicionEstadoFisico EstadoFisicoPersona { get; set; }
    public bool EnfermedadRespiratoriaBase { get; set; }
    public int RangoEdad { get; set; }
    public bool Sedentario { get; set; }
    public CondicionSocial EstadoSocial { get; set; }
    public string LugarTrabajoExpoCovid { get; set; }

}

public enum CondicionEstadoFisico
{
    bueno,
    regular,
    malo
}

public enum CondicionSocial
{
    Alta,
    Media,
    Baja,
    Pobreza
}




