using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ServerModels;
using TMPro;
using System.Text;
using PlayFab.ClientModels;
using ItemInstance = PlayFab.ServerModels.ItemInstance;
using GetUserInventoryRequest = PlayFab.ServerModels.GetUserInventoryRequest;
using GetUserInventoryResult = PlayFab.ServerModels.GetUserInventoryResult;
using DG.Tweening;
using System.Linq;

//PARA PRUEBAS
using UnityEngine.Networking;
using Newtonsoft.Json;

public class GameManager : MonoBehaviour
{

    public event Action OnLoading;

    public event Action OnLogin;
    public event Action OnRegister;
    public event Action onDescActivity;
    public event Action onAsistenteInfo;
    public event Action onAsistenteStartPaso;
    public event Action onRegisterSpace;
    public event Action onRegisterSpaceAccion;
    public event Action onNextPaso;
    public event Action onEndActivity;
    public event Action onEndActivityTimer0;
    

    public event Action onBoxObjetosOpen;
    public event Action onARPositionObject;
    public event Action OnItemsMenu;
    public event Action OnARPosition;


    [Header("Pacient")]
    [SerializeField] private GameObject loginCanvas;
    [SerializeField] private GameObject optionsCanvas;
    [SerializeField] private GameObject descActivityCanvas;
    [SerializeField] private GameObject endActivityCanvas;

    [Header("Login")]
    public Text messageText;
    public InputField emailInput;
    public InputField passwordInput;

    [Header("Register")]
    public Text messageInfo;
    public InputField emailInputRegister;
    public InputField password1InputRegister;
    public InputField password2InputRegister;

    [Header("Descripcion Actividad")]
    public Text nameAct;
    public Text maxPuntuacion;
    string maxPunt = "0";
    public Text creadorAct;
    public Text descAct;
    public Text pasosAct;
    public Text timeAct;

    [Header("Asistente Info ")]
    public Text nameActInfo;

    [Header("StartPaso")]
    public Text namePaso1;
    public Text bocadilloNombreAct;
    public Text bocadilloPrimerPaso;
    public Text bocadilloNombreUbicacion;
    public Text bocadilloObjetosPaso1;

    [Header("Register space")]
    public Text espacioRegister;

    [Header("Realizar Paso")]
    public Text accionRealizar;


    [Header("Next Paso")]
    public Text actNamee;
    public Text feedback;

    [Header("End Activity")]
    public Text bocadilloNombreActFin;
    public Text actFinName;
    public Text timeFin;
    public Text puntuacionFin;
    public Text feedbackFin;

    [Header("End ActivityTimer0")]
    public Text bocadilloNombreActFinTimer0;
    public Text actFinNameTimer0;
    public Text feedbackFinTimer;

    [Header("Datos de la actividad para mostrar en PRACTITIONER")]
    [SerializeField] private Text _tittle0;
    [SerializeField] private Text _tittle1;
    [SerializeField] private Text _tittle2;
    [SerializeField] private Text _tittle3;
    [SerializeField] private Text _tittle4;
    [SerializeField] private Text _tittle5;
    [SerializeField] private Text _tittle6;
    [SerializeField] private Text _tittle7;
    [SerializeField] private Text _tittle8;
    [SerializeField] private Text _tittle9;
    [SerializeField] private Text _tittle10;
    [SerializeField] private Text _tittle11;
    [SerializeField] private Text _tittle12;
    [SerializeField] private Text _tittle13;
    [SerializeField] private Text _tittle14;
    [SerializeField] private Text _tittle15;
    [SerializeField] private Text _tittle16;
    [SerializeField] private Text _tittle17;
    [SerializeField] private Text _tittle18;
    [SerializeField] private Text _tittle19;
    [SerializeField] private Text _tittle20;
    [SerializeField] private Text _tittle21;
    [SerializeField] private Text _tittle22;
    [SerializeField] private Text _tittle23;
    [SerializeField] private Text _tittle24;
    [SerializeField] private Text _tittle25;
    [SerializeField] private Text _tittle26;
    [SerializeField] private Text _tittle27;
    [SerializeField] private Text _tittle28;
    [SerializeField] private Text _tittle29;
    [SerializeField] private Text _tittle30;
    [SerializeField] private Text _tittle31;
    [SerializeField] private Text _tittle32;
    [SerializeField] private Text _tittle33;
    [SerializeField] private Text _tittle34;
    [SerializeField] private Text _tittle35;
    [SerializeField] private Text _tittle36;
    [SerializeField] private Text _tittle37;
    [SerializeField] private Text _tittle38;
    [SerializeField] private Text _tittle39;
    [SerializeField] private Text _tittle40;
    [SerializeField] private Text _tittle41;
    [SerializeField] private Text _tittle42;
    [SerializeField] private Text _tittle43;
    [SerializeField] private Text _tittle44;
    [SerializeField] private Text _tittle45;
    [SerializeField] private Text _tittle46;
    [SerializeField] private Text _tittle47;
    [SerializeField] private Text _tittle48;
    [SerializeField] private Text _tittle49;

    [SerializeField] private Text _description0;
    [SerializeField] private Text _description1;
    [SerializeField] private Text _description2;
    [SerializeField] private Text _description3;
    [SerializeField] private Text _description4;
    [SerializeField] private Text _description5;
    [SerializeField] private Text _description6;
    [SerializeField] private Text _description7;
    [SerializeField] private Text _description8;
    [SerializeField] private Text _description9;
    [SerializeField] private Text _description10;
    [SerializeField] private Text _description11;
    [SerializeField] private Text _description12;
    [SerializeField] private Text _description13;
    [SerializeField] private Text _description14;
    [SerializeField] private Text _description15;
    [SerializeField] private Text _description16;
    [SerializeField] private Text _description17;
    [SerializeField] private Text _description18;
    [SerializeField] private Text _description19;
    [SerializeField] private Text _description20;
    [SerializeField] private Text _description21;
    [SerializeField] private Text _description22;
    [SerializeField] private Text _description23;
    [SerializeField] private Text _description24;
    [SerializeField] private Text _description25;
    [SerializeField] private Text _description26;
    [SerializeField] private Text _description27;
    [SerializeField] private Text _description28;
    [SerializeField] private Text _description29;
    [SerializeField] private Text _description30;
    [SerializeField] private Text _description31;
    [SerializeField] private Text _description32;
    [SerializeField] private Text _description33;
    [SerializeField] private Text _description34;
    [SerializeField] private Text _description35;
    [SerializeField] private Text _description36;
    [SerializeField] private Text _description37;
    [SerializeField] private Text _description38;
    [SerializeField] private Text _description39;
    [SerializeField] private Text _description40;
    [SerializeField] private Text _description41;
    [SerializeField] private Text _description42;
    [SerializeField] private Text _description43;
    [SerializeField] private Text _description44;
    [SerializeField] private Text _description45;
    [SerializeField] private Text _description46;
    [SerializeField] private Text _description47;
    [SerializeField] private Text _description48;
    [SerializeField] private Text _description49;

    //VARIABLE PARA GUARDAR LAS ACTIVIDADES
    //List<Activities> actividades = new List<Activities>();
    List<int> activitiesIds = new List<int>();

    List<Step> stepsInActiviy = new List<Step>();
    Step stepInformation = new Step();
    List<int> stepsIds = new List<int>();
    int stepAux = 0;

    string regUbicacionAntigua = null;


    //Patron Singleton
    public static GameManager instance;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    //START DE LA APLICACI�N
    void Start()
    {
        //Llamo a la pantalla de loading
        LoadingMenu();
        //Llamo a collect Actividades
    }

    //MUESTRO PANTALLA DE LOADING
    public void LoadingMenu()
    {
        OnLoading?.Invoke();
        Debug.Log("Loading 0 menu ACTIVATED");
        StartCoroutine(Loadingg());
    }

    //TRAS DOS SEGUNDOS DESAPARECE EL LOADING
    IEnumerator Loadingg()
    {
        yield return new WaitForSecondsRealtime(2);
        LoginMenu();
    }

    //SE INVOCA LA PANTALLA DE LOGIN
    /*
     * PARA HACER EL LOGIN EL PROYECTO SE CONECTA CON LA BBDD DE PLAYFAB DONDE ESTAN CREADOS LOS USUARIOS
     * UN USUARIO QUE PUEDES USAR ES:
     * USER: marta@uclm.es PASSWORD: 123456
    */
    public void LoginMenu()
    {
        OnLogin?.Invoke();
        Debug.Log("Login menu ACTIVATED");
    }


    //PANTALLA DE REGISTER
    public void RegisterMenu()
    {
        Debug.Log("Register menu ACTIVATED");
        OnRegister?.Invoke();
    }

    
    //CORRUTINAS QUE SE USAN PARA LA BBDD SE CREAR�N ACTIVIDADAS AUXILIARES PARA QUE NO SE USEN
    /*
    IEnumerator CollectActivitiesByUser()
    {
        string usuario = emailInput.text;
        //string usuario = "marta@uclm.es";


        UnityWebRequest www = UnityWebRequest.Get("localhost:3001/api/Activity2User/GetActivitiesAssigned2User?user=" + usuario);
        yield return www.Send();

        if (www.isError)
        {
            Debug.Log(www.error);
        }

        var activitiesByUSer = JsonConvert.DeserializeObject<List<Activities>>(www.downloadHandler.text);

        actividades = activitiesByUSer;

        foreach (var act in actividades)
        {
            activitiesIds.Add(act.activityId);
            
        }

        ActivateOptionsMenu();
    }
    IEnumerator CollectStepsByActivityId()
    {
        int activityId = idActividadSeleccionada;

        UnityWebRequest www = UnityWebRequest.Get("http://localhost:3001/api/Steps/GetSteps?idActivity=" + activityId);
        yield return www.Send();

        if (www.isError)
        {
            Debug.Log(www.error);
        }

        var stepInfo = JsonConvert.DeserializeObject<List<Step>>(www.downloadHandler.text);
        stepsInActiviy = stepInfo;

        foreach (var s in stepsInActiviy)
        {
            stepsIds.Add(s.id);
        }

        InfoActivityComplete();
    }
    IEnumerator GetStepsById()
    {
        int stepId = stepsIds[stepAux];

        UnityWebRequest www = UnityWebRequest.Get("http://localhost:3001/api/Steps/GetStep?id=" + stepId);
        yield return www.Send();

        if (www.isError)
        {
            Debug.Log(www.error);
        }

        var stepInfo = JsonConvert.DeserializeObject<Step>(www.downloadHandler.text);
        stepInformation = stepInfo;

        AsistenteStartPasoMenu();
    }
    */

    //CUANDO SE PRESIONA EL BOTON PARA REGISTRAR
    public void RegisterButton()
    {
        if (password1InputRegister.text == password2InputRegister.text)
        {
            var request = new RegisterPlayFabUserRequest
            {
                Email = emailInputRegister.text,
                Password = password1InputRegister.text,
                RequireBothUsernameAndEmail = false,
            };
            PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess, OnError);
        }
        else
        {
            messageInfo.text = "LAS CONTRASE�S NO COINCIDEN";
        }
    }




    //SI TODOS LOS VALORES DEL REGISTRO ESTAN BIEN SE CREA EL USUARIO
    void OnRegisterSuccess(RegisterPlayFabUserResult result)
    {
        messageInfo.text = "REGISTRADO CORRECTAMENTE";
    }


    //CUANDO SE PRESIONA EL BOTON DE LOGIN
    public void PressLoginButton()
    {
        DoLogin(emailInput.text, passwordInput.text);
    }


    //SE PASAN LOS VALORES DEL LOGIN PARA COMPROBAR QUE ESTAN BIEN
    public void DoLogin(string email, string pass)
    {
        var request = new LoginWithEmailAddressRequest
        {
            Email = email,
            Password = pass
        };
        PlayFabClientAPI.LoginWithEmailAddress(request, OnLoginSuccess, OnError);
    }


    List<string> actividades = new List<string>()
    {
        "1", "2"
    };

    List<string> infoActividad1 = new List<string>()
    {
        "Recoger Habitacion", "Vamos a ordenar tu habitacion", "terapeuta1@uclm", "700", "Colocar camiseta", "Colocar Pantalon", "Colocar Zapatillas", "habitacion", "habitacion", "habitacion" , "camsieta", "pantalon", "zapatillas"
    };

    List<string> infoActividad2 = new List<string>()
    {
        "Llevar libro", "Llevar libro de la habitacion al salon (Se debe colocar el libro tanto en la habitacion como en el salon", "terapeuta1@uclm.es", "500","Colocar libro la habitacion", "Colocar el libro en el salon", "habitacion", "salon", "libro", "libro"
    };

    //SI LOS VALORES DEL LOGIN ESTAN BIEN
    private void OnLoginSuccess(LoginResult result)
    {
        Debug.Log("Succesful login/account create!!");
        //StartCoroutine("CollectActivitiesByUser");
        ActivateOptionsMenu();
    }


    //SE CONTROLAN POSIBLES ERRORES PARA REGISTER Y LOGIN
    private void OnError(PlayFabError error)
    {
        Debug.Log("Error while logging in/creating account");
        Debug.Log(error.GenerateErrorReport());
    }


    //FUNCION PARA MOSTRAR LA LISTA DE LAS ACTIVIDADES
    public void ActivateOptionsMenu()
    {
        Debug.Log("Options menu ACTIVATED");
        StopCoroutine("CollectActivitiesByOwner");

        endActivityCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        loginCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        optionsCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        optionsCanvas.transform.GetChild(0).GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        optionsCanvas.transform.GetChild(0).GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        optionsCanvas.transform.GetChild(0).GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        int i = 0;
        int numActividad = 0;

        foreach (var actividad in actividades)
        {
            if (numActividad == 0)
            {
                optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(i).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
                _tittle0.text = infoActividad1[0];
                _description0.text = infoActividad1[1];
                i++;
            }
            if (numActividad == 1)
            {
                optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(i).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
                _tittle1.text = infoActividad2[0];
                _description1.text = infoActividad2[1];
                i++;
            }
            
            numActividad++;
        }

        optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        optionsCanvas.transform.GetChild(0).GetChild(3).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        optionsCanvas.transform.GetChild(0).GetChild(4).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        descActivityCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

    }

    //FUNCION PARA VOLVER AL LOGIN
    public void VolverLogin()
    {
        OnLogin?.Invoke();
        activitiesIds.Clear();
    }

    int idActividadSeleccionada;
    int activityId;
    

    //FUNCIONES PARA MOSTRAR LA INFORMACION DE UNA ACTIVIDAD
    public void Act1Aux0()
    {
        activityId = 1;

        nameAct.text = infoActividad1[0];
        maxPuntuacion.text = maxPunt;
        descAct.text = infoActividad1[1];
        creadorAct.text = infoActividad1[2];
        timeAct.text = infoActividad1[3];
        pasosAct.text = infoActividad1[4] + ", " +infoActividad1[5] + ", " + infoActividad1[6];

        onDescActivity?.Invoke();
        //StartCoroutine("CollectStepsByActivityId");
    }
    public void Act1Aux1()
    {
        activityId = 2;

        nameAct.text = infoActividad2[0];
        maxPuntuacion.text = maxPunt;
        descAct.text = infoActividad2[1];
        creadorAct.text = infoActividad2[2];
        timeAct.text = infoActividad2[3];
        pasosAct.text = infoActividad2[4] + ", " + infoActividad2[5];
        

        onDescActivity?.Invoke();
        //StartCoroutine("CollectStepsByActivityId");
    }


    //SE RELLENA TODA LA INFORMACION DE LA ACTIVIDAD PARA MOSTRARLA 
    //PARA NUESTRO CASO NO SE USAR�
    /*
    public void InfoActivityComplete()
    {

        StopCoroutine("CollectStepsByActivityId");

        nameAct.text = actividades[activity].Name;
        maxPuntuacion.text = maxPunt;
        descAct.text = actividades[activity].Description;
        creadorAct.text = actividades[activity].Owner;
        timeAct.text = actividades[activity].MaxTime.ToString();

        int numStep = 0;
        int aux = 1;
        foreach (var s in stepsInActiviy)
        {
            if (numStep == 0)
            {
                
                if (s.stepDescriptions[0].Description == "string")
                {
                    pasosAct.text = "Paso 1 --> No hay descripcion";
                }
                else
                {
                    pasosAct.text = "Paso 1 --> " + s.stepDescriptions[0].Description;
                }
            }
            else
            {
                if (s.stepDescriptions[0].Description == "string")
                {
                    pasosAct.text = pasosAct.text + "\nPaso " + aux + " --> No hay descripcion";
                }
                else
                {
                    pasosAct.text = pasosAct.text + "\nPaso " + aux + " --> " + s.stepDescriptions[0].Description;
                }
            }

            aux++;
            numStep++;
        }

        onDescActivity?.Invoke();
    }
    */


    //BOTON PARA VOLVER AL LISTADO DE LAS ACTIVIDADES DEL USUARIO
    public void VolverOptions()
    {
        //stepsInActiviy.Clear();
        //stepsIds.Clear();
        activityId = 0;
        ActivateOptionsMenu();
    }


    //SE MUESTRA INFORMACION AUXILIAR ANTES DE EMPEZAR LA ACTIVIDAD
    public void AsistenteInfoMenu()
    {
        onAsistenteInfo?.Invoke();
        Debug.Log("Asistente Info Menu ACTIVATED");
    }

    [SerializeField] Text tiempo;

    private float restante;
    private bool enMarcha;
    int contadorPasos = 1;
    int numero;
    //FUNCION AUXLIAR PARA RECOGER LA INFORMACION DEL PASO QUE SE VA A RELIZAR
    public void AsistenteStartPasoAux()
    {

        if (activityId == 1)
        {
            numero = 3;
            restante = 700.0f;
        }
        else
        {
            numero = 2;
            restante = 500.0f;
        }

        Aux();
        enMarcha = true;

    }

    public void Aux()
    {
        if (numero == 0)
        {
            EndActivityMenuControlador();

        }
        else
        {
            AsistenteStartPasoMenu();
            numero--;
        }

    }



    //CONTADOR PARA REALIZAR LA ACTIVIDAD
    void Update()
    {
        
       
        if (enMarcha == true)
        {
            restante -= Time.deltaTime;
            if (restante < 1)
            {
                EndActivityMenuControladorTimer0();
            }
            int tempMin = Mathf.FloorToInt(restante / 60); 
            int tempSeg = Mathf.FloorToInt(restante % 60);

            tiempo.text = string.Format("{00:00}:{01:00}", tempMin, tempSeg);
        }
    }

    //SE MUESTRA LA INFORMACION DEL PASO QUE SE VA A REALIZAR
    public void AsistenteStartPasoMenu()
    {
        //StopCoroutine("GetStepsById");

        if (activityId == 1)
        {
            if (contadorPasos == 1)
            {
                namePaso1.text = infoActividad1[0];
                bocadilloNombreAct.text = infoActividad1[0];
                bocadilloPrimerPaso.text = infoActividad1[4];
                bocadilloNombreUbicacion.text = infoActividad1[7];
                bocadilloObjetosPaso1.text = infoActividad1[10];

            }
            else if (contadorPasos == 2)
            {
                namePaso1.text = infoActividad1[0];
                bocadilloNombreAct.text = infoActividad1[0];
                bocadilloPrimerPaso.text = infoActividad1[5];
                bocadilloNombreUbicacion.text = infoActividad1[8];
                bocadilloObjetosPaso1.text = infoActividad1[11];
            }
            else if (contadorPasos == 3)
            {
                namePaso1.text = infoActividad1[0];
                bocadilloNombreAct.text = infoActividad1[0];
                bocadilloPrimerPaso.text = infoActividad1[6];
                bocadilloNombreUbicacion.text = infoActividad1[9];
                bocadilloObjetosPaso1.text = infoActividad1[12];
            }
        }

        if (activityId == 2)
        {
            if (contadorPasos == 1)
            {
                namePaso1.text = infoActividad2[0];
                bocadilloNombreAct.text = infoActividad2[0];
                bocadilloPrimerPaso.text = infoActividad2[4];
                bocadilloNombreUbicacion.text = infoActividad2[6];
                bocadilloObjetosPaso1.text = infoActividad2[8];
            }
            else if (contadorPasos == 2)
            {
                namePaso1.text = infoActividad2[0];
                bocadilloNombreAct.text = infoActividad2[0];
                bocadilloPrimerPaso.text = infoActividad2[5];
                bocadilloNombreUbicacion.text = infoActividad2[7];
                bocadilloObjetosPaso1.text = infoActividad2[9];
            }
        }


        onAsistenteStartPaso?.Invoke();
      
    }

    //AQUI SE REGISTRA EL ESPACIO
    public void RegisterSpaceMenu()
    {

        if (activityId == 1)
        {
            if (contadorPasos == 1)
            {
                if (regUbicacionAntigua != infoActividad1[7])
                {
                    regUbicacionAntigua = infoActividad1[7];
                    espacioRegister.text = infoActividad1[7];
                    onRegisterSpace?.Invoke();
                    Debug.Log("Register Space menu ACTIVATED");
                }
                else
                {
                    RegisterSpaceAccion();
                }
            }
            else if (contadorPasos == 2)
            {
                if (regUbicacionAntigua != infoActividad1[8])
                {
                    regUbicacionAntigua = infoActividad1[8];
                    espacioRegister.text = infoActividad1[8];
                    onRegisterSpace?.Invoke();
                    Debug.Log("Register Space menu ACTIVATED");
                }
                else
                {
                    RegisterSpaceAccion();
                }
            }
            else if (contadorPasos == 3)
            {
                if (regUbicacionAntigua != infoActividad1[9])
                {
                    regUbicacionAntigua = infoActividad1[9];
                    espacioRegister.text = infoActividad1[9];
                    onRegisterSpace?.Invoke();
                    Debug.Log("Register Space menu ACTIVATED");
                }
                else
                {
                    RegisterSpaceAccion();
                }
            }
        }

        if (activityId == 2)
        {
            if (contadorPasos == 1)
            {
                if (regUbicacionAntigua != infoActividad2[6])
                {
                    regUbicacionAntigua = infoActividad2[6];
                    espacioRegister.text = infoActividad2[6];
                    onRegisterSpace?.Invoke();
                    Debug.Log("Register Space menu ACTIVATED");
                }
                else
                {
                    RegisterSpaceAccion();
                }
            }
            else if (contadorPasos == 2)
            {
                if (regUbicacionAntigua != infoActividad2[7])
                {
                    regUbicacionAntigua = infoActividad2[7];
                    espacioRegister.text = infoActividad2[7];
                    onRegisterSpace?.Invoke();
                    Debug.Log("Register Space menu ACTIVATED");
                }
                else
                {
                    RegisterSpaceAccion();
                }
            }
        }
        
    }

    //CUANDO SE HA REGISTRADO DEBE APARECER EL PREFAB QUE SE HA ANCLADO EN LA OTRA APP PARA SELECCIONARLO
    //ESTAN AS� PARA PODER HACER EL FLUJO EN VERDAD DEBERIA SALR TODO EN UNA
    public void RegisterSpaceAccion()
    {

        if (activityId == 1)
        {
            if (contadorPasos == 1)
            {

                accionRealizar.text = infoActividad1[4];
                onRegisterSpace?.Invoke();
                Debug.Log("Register Space menu ACTIVATED");
                
            }
            else if (contadorPasos == 2)
            {
                accionRealizar.text = infoActividad1[5];
                onRegisterSpace?.Invoke();
                    Debug.Log("Register Space menu ACTIVATED");
               
            }
            else if (contadorPasos == 3)
            {

                accionRealizar.text = infoActividad1[6];
                onRegisterSpace?.Invoke();
                Debug.Log("Register Space menu ACTIVATED");
                 
            }
        }

        if (activityId == 2)
        {
            if (contadorPasos == 1)
            {

                accionRealizar.text = infoActividad2[4];
                onRegisterSpace?.Invoke();
                Debug.Log("Register Space menu ACTIVATED");
                
            }
            else if (contadorPasos == 2)
            {
                accionRealizar.text = infoActividad2[5];
                onRegisterSpace?.Invoke();
                Debug.Log("Register Space menu ACTIVATED");
              
            }
        }

        onRegisterSpaceAccion?.Invoke();
        
    }

    //FUNCION INFORMATIVA PARA IR AL SIGUIENTE PASO IR� A AsistenteStartPasoAux ahora es AUX
    //SI HAY MAS PASOS VA A AsistenteStartPasoMenu
    //SI NO HAY MAS PASOS VA A EndActivityMenuControlador
    public void NextPasoMenuControlador()
    {
        if (activityId == 1)
        {
            actNamee.text = infoActividad1[0];
            feedback.text = "Bien hecho";
        }
        else if (activityId == 2)
        {
            actNamee.text = infoActividad2[0];
            feedback.text = "Bien hecho";
        }

        contadorPasos++;
        onNextPaso?.Invoke();
    }

    //NO HAY MAS PASOS E INFORMA QUE SE HA TERMINADO LA ACTIVIDAD
    public void EndActivityMenuControlador()
    {
        float timeInicial = 0; ;
        if(activityId == 1)
        {
            timeInicial = 700.0f;
            bocadilloNombreActFin.text = infoActividad1[0];
            actFinName.text = infoActividad1[0];

        }
        else if (activityId == 2)
        {
            timeInicial = 500.0f;
            bocadilloNombreActFin.text = infoActividad1[1];
            actFinName.text = infoActividad1[1];
        }
        
        Debug.Log("timeInicial --> " + timeInicial);
        float timeFinn = restante;
        Debug.Log("timeFinn --> " + timeFinn);

        float calculate = (timeFinn * 10) / timeInicial;


        Debug.Log("calculate --> " + calculate);


        
        
        
        timeFin.text = (timeInicial - timeFinn).ToString() + "segundos";


        if (timeInicial > timeFinn)
        {
            feedbackFin.text = "BIEN HECHO";

            if (calculate > 6.9)
            {
                puntuacionFin.text = "10";
            }
            else if (calculate > 4.9)
            {
                puntuacionFin.text = "7";
            }
            else if (calculate > 2.9)
            {
                puntuacionFin.text = "5";
            }
            else
            {
                puntuacionFin.text = "3";
            }
        }
        else
        {
            feedbackFin.text = "No lo lograste";
            puntuacionFin.text = "0";
        }

        maxPunt = puntuacionFin.text;

        onEndActivity?.Invoke();
    }

    //SI EL TIEMPO SE ACABA FIN
    public void EndActivityMenuControladorTimer0()
    {

        enMarcha = false;

        if(activityId == 1)
        {
            bocadilloNombreActFinTimer0.text = infoActividad1[0];
            actFinNameTimer0.text = infoActividad1[0];
            feedbackFinTimer.text = "MAL HECHO";
        }
        else if(activityId == 2)
        {
            bocadilloNombreActFinTimer0.text = infoActividad2[0];
            actFinNameTimer0.text = infoActividad2[0];
            feedbackFinTimer.text = "MAL HECHO";
        }

        

        maxPunt = "0";

        onEndActivityTimer0?.Invoke();
    }


    //FUNCION PARA SALIR DE REALIZAR LA ACTIVIDAD
    public void SalirDoActivity()
    {
        stepAux = 0;
        stepsIds.Clear();
        stepsInActiviy.Clear();
        regUbicacionAntigua = null;
        //StartCoroutine("CollectStepsByActivityId");
        contadorPasos = 1;
        activityId = 0;
        ActivateOptionsMenu();
    }


    //FUNCION PARA SALIR DE LA APLICACION
    public void CloseApp()
    {
        Application.Quit();
    }

    

    //ESTAS FUNCIONES YA NO SE USAN ESTARIA BIEN BORRARLAS DEL C�DIGO
    public void BoxObjetosOpenMenu()
    {

        //objetoAColocar.text = stepInformation.stepDescriptions[0].entities[0].entityName;

        onBoxObjetosOpen?.Invoke();
        Debug.Log("Box Objetos Open menu ACTIVATED");
    }
    public void ARPositionObjectMenu()
    {
        onARPositionObject?.Invoke();
        Debug.Log("AR Position Object menu ACTIVATED");
    }
    public void ItemsMenu()
    {
        OnItemsMenu?.Invoke();
        Debug.Log("Item menu ACTIVATED");
    }
    public void ARPosition()
    {
        OnARPosition?.Invoke();
        Debug.Log("AR Position ACTIVATED");
    }

    
}



