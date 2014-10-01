<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Overview</title>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE8" />
    <meta content="Scroll Wiki Publisher" name="generator"/>
    <link type="text/css" rel="stylesheet" href="css/blueprint/liquid.css" media="screen, projection"/>
    <link type="text/css" rel="stylesheet" href="css/blueprint/print.css" media="print"/>
    <link type="text/css" rel="stylesheet" href="css/content-style.css" media="screen, projection, print"/>
    <link type="text/css" rel="stylesheet" href="css/screen.css" media="screen, projection"/>
    <link type="text/css" rel="stylesheet" href="css/print.css" media="print"/>
</head>
<body>
                <h1>Overview</h1>
    <p>
            <img src="images_community/download/attachments/8651084/icon.png" alt="images_community/download/attachments/8651084/icon.png" class="confluence-embedded-image" />
            </p>
    <p>
This action plugin enables <strong class=" ">pushing dynaTrace Incident data to System Center Operations Manager 2007 - 2012</strong>    </p>
    <div class="tablewrap">
        <table>
<thead class=" "></thead><tfoot class=" "></tfoot><tbody class=" ">    <tr>
            <td rowspan="1" colspan="1">
        <p>
Name    </p>
            </td>
                <td rowspan="1" colspan="1">
        <p>
SCOM Action Monitoring Plugin for dynaTrace    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
        <p>
Plugin Version    </p>
            </td>
                <td rowspan="1" colspan="1">
        <p>
1.2 (updated by Eric Lazar to now also Support SCOM 2012)    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
        <p>
Compatible with    </p>
            </td>
                <td rowspan="1" colspan="1">
        <p>
dynaTrace 3.0+, dynaTrace 4.x, dynaTrace 5.x    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
        <p>
Tested with:    </p>
            </td>
                <td rowspan="1" colspan="1">
        <p>
System Center Operations Manager 2007 + 2012    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
        <p>
Author    </p>
            </td>
                <td rowspan="1" colspan="1">
        <p>
Andreas Grabner, Steve Caron, Eric Lazar    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
        <p>
Download    </p>
            </td>
                <td rowspan="1" colspan="1">
        <p>
<a href="attachments_160071690_2_dynaTrace_SCOMAlert_v1.2.zip">dynaTrace_SCOMAlert_v1.2.zip</a> (also works with SCOM 2012 - Thanks to Eric Lazar)<br/><a href="attachments_134742218_1_dynaTrace_SCOMAlert_v1.1.zip">dynaTrace_SCOMAlert_v1.1.zip</a> (works with SCOM 2007<br/><br/><a href="attachments_160071689_1_dynaTrace_SCOMAlert_v1.2_Source.zip">Download v1.2 Source</a>    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
        <p>
License    </p>
            </td>
                <td rowspan="1" colspan="1">
        <p>
<a href="attachments_5275722_2_dynaTraceBSD.txt">dynaTrace BSD</a>    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
        <p>
Support    </p>
            </td>
                <td rowspan="1" colspan="1">
        <p>
<a href="https://community/display/DL/Support+Levels#SupportLevels-Community">Community Supported</a>    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
        <p>
Screenshots    </p>
            </td>
                <td rowspan="1" colspan="1">
        <p>
<strong class=" ">Imported SCOM Action Plugin</strong><br/>            <img src="images_community/download/attachments/8651084/plugin_import.PNG" alt="images_community/download/attachments/8651084/plugin_import.PNG" class="" />
        <br/><br/><strong class=" ">Plugin Properties</strong><br/>            <img src="images_community/download/attachments/8651084/plugin_properties.PNG" alt="images_community/download/attachments/8651084/plugin_properties.PNG" class="" />
        <br/><br/><strong class=" ">Incident Definition</strong><br/>            <img src="images_community/download/attachments/8651084/incident_definition.PNG" alt="images_community/download/attachments/8651084/incident_definition.PNG" class="" />
        <br/><br/><strong class=" ">SCOM Management Pack Import</strong><br/>            <img src="images_community/download/attachments/8651084/managementpacks.PNG" alt="images_community/download/attachments/8651084/managementpacks.PNG" class="" />
        <br/><br/><strong class=" ">dynaTrace Alert in SCOM</strong><br/>            <img src="images_community/download/attachments/8651084/alerts_in_scom.PNG" alt="images_community/download/attachments/8651084/alerts_in_scom.PNG" class="" />
            </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
        <p>
Install Description    </p>
            </td>
                <td rowspan="1" colspan="1">
        <p>
1) Install the dynaTrace_ManagementPack.xml in SCOM. You can do this in the Administration Pane in the SCOM Management Operation Console<br/>2) Make sure to have the windows service &quot;OpsMgr SDK Service&quot; running. Verify that by looking at the list of windows services.<br/>3) Initialize dynaTrace SCOM Objects by executing dynaTrace.SCOM.exe with the /i parameter. Execute dynaTrace.SCOM.exe without any parameters to get a list of options that you have. /i allows you to install the needed SCOM objects on your SCOM 2007 server. dynaTrace.SCOM.exe is a .NET Console Application. It requires an installed .NET 2.0 Framework.<br/>4) Import the Action Plugin into the dynaTrace Server (via Server Preferences). Click on the Plugins tab and import com.dynatrace.diagnostics.plugin.SCOMAction_1.0.0.jar. After you have imported it you can specify default values for the plugin properties.<br/>5) Use the Plugin as Action for an Incident. Make sure to configure all required properties of the Plugin<br/><strong class=" "> </strong><br/><strong class=" ">Plugin-Properties</strong>    </p>
<ul class=" "><li class=" ">    <p>
SCOMServer: name of the server that runs SCOM    </p>
</li><li class=" ">    <p>
Username: username to authenticate on SCOM in order to send events to SCOM    </p>
</li><li class=" ">    <p>
Domain: windows domain name for the user    </p>
</li><li class=" ">    <p>
Password: password for the user    </p>
</li><li class=" ">    <p>
CustomMessage: if specified - this message will be part of the alert description that is generated in SCOM    </p>
</li><li class=" ">    <p>
Plugin Installation Path: (optional). You can install dynaTrace.SCOM.exe, dynaTrace.SCOM.exe.config and the two microsoft dlls in any directory on the dynaTrace Server machine. If you do so you can specify the installation directory here. If this parameter is not specified the dynaTrace.SCOM.exe will be extracted from the dynaTrace SCOM Alert Plugin and stored in a temporary directory on the dynaTrace server<br/><strong class=" "> </strong><br/><strong class=" ">What is part of the SCOM Alert?</strong><br/>dynaTrace sends an event to SCOM containing the name of the Incident as Event name, the description of the incident and optionally the custom message as event description and the defined severity as event severity.<br/>The event data will then be converted into a SCOM Alert by the dynaTrace Management Pack.    </p>
</li></ul>            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
        <p>
Compatibility Matrix    </p>
            </td>
                <td rowspan="1" colspan="1">
        <p>
    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
        <p>
Known Problems    </p>
            </td>
                <td rowspan="1" colspan="1">
        <p>
The action plugin executes dynaTrace.SCOM.exe on the dynaTrace server. dynaTrace.SCOM.exe is a .NET Console Application. Therefore this Plugin only works on dynaTrace servers that run on windows with an installed version of the .NET 2.0 Framework.    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
        <p>
Disclaimer    </p>
            </td>
                <td rowspan="1" colspan="1">
        <p>
    </p>
            </td>
        </tr>
</tbody>        </table>
            </div>
    <p>
    </p>
    <div class="tablewrap">
        <table>
<thead class=" ">    <tr>
            <td rowspan="1" colspan="1">
        <p>
&nbsp;    </p>
            </td>
                <td rowspan="1" colspan="1">
        <p>
<a href="SCOM_Action_Monitoring_Plugin.html">File</a>    </p>
            </td>
                <td rowspan="1" colspan="1">
        <p>
<a href="SCOM_Action_Monitoring_Plugin.html">Modified</a>    </p>
            </td>
        </tr>
</thead><tfoot class=" "></tfoot><tbody class=" ">    <tr>
            <td rowspan="1" colspan="1">
                </td>
                <td rowspan="1" colspan="1">
        <p>
ZIP Archive                    <a href="https://community/download/attachments/8651084/dynaTrace_SCOMAlert_v1.2.zip?api=v2">dynaTrace_SCOMAlert_v1.2.zip</a>    </p>
            </td>
                <td rowspan="1" colspan="1">
        <p>
Mar 14, 2014by<a href="    /community/display/~andreas.grabner@compuware.com ">Andreas Grabner</a>    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
                </td>
                <td rowspan="1" colspan="2">
        <p>
    </p>
    <p>
Labels    </p>
<ul class="label-list has-pen "><li class="no-labels-message ">    <p>
No labels    </p>
</li><li class="labels-edit-container ">    <p>
<a href="SCOM_Action_Monitoring_Plugin.html">Edit Labels</a>    </p>
</li></ul>    <p>
    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
                </td>
                <td rowspan="1" colspan="1">
        <p>
ZIP Archive                    <a href="https://community/download/attachments/8651084/dynaTrace_SCOMAlert_v1.2_Source.zip?api=v2">dynaTrace_SCOMAlert_v1.2_Source.zip</a>    </p>
            </td>
                <td rowspan="1" colspan="1">
        <p>
Mar 14, 2014by<a href="    /community/display/~andreas.grabner@compuware.com ">Andreas Grabner</a>    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
                </td>
                <td rowspan="1" colspan="2">
        <p>
    </p>
    <p>
Labels    </p>
<ul class="label-list has-pen "><li class="no-labels-message ">    <p>
No labels    </p>
</li><li class="labels-edit-container ">    <p>
<a href="SCOM_Action_Monitoring_Plugin.html">Edit Labels</a>    </p>
</li></ul>    <p>
    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
                </td>
                <td rowspan="1" colspan="1">
        <p>
ZIP Archive                    <a href="https://community/download/attachments/8651084/dynaTrace_SCOMAlert_Source.zip?api=v2">dynaTrace_SCOMAlert_Source.zip</a>    </p>
            </td>
                <td rowspan="1" colspan="1">
        <p>
Aug 13, 2013by<a href="    /community/display/~andreas.grabner@compuware.com ">Andreas Grabner</a>    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
                </td>
                <td rowspan="1" colspan="2">
        <p>
    </p>
    <p>
Labels    </p>
<ul class="label-list has-pen "><li class="no-labels-message ">    <p>
No labels    </p>
</li><li class="labels-edit-container ">    <p>
<a href="SCOM_Action_Monitoring_Plugin.html">Edit Labels</a>    </p>
</li></ul>    <p>
    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
                </td>
                <td rowspan="1" colspan="1">
        <p>
ZIP Archive                    <a href="https://community/download/attachments/8651084/dynaTrace_SCOMAlert_v1.1.zip?api=v2">dynaTrace_SCOMAlert_v1.1.zip</a>    </p>
            </td>
                <td rowspan="1" colspan="1">
        <p>
Aug 13, 2013by<a href="    /community/display/~andreas.grabner@compuware.com ">Andreas Grabner</a>    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
                </td>
                <td rowspan="1" colspan="2">
        <p>
    </p>
    <p>
Labels    </p>
<ul class="label-list has-pen "><li class="no-labels-message ">    <p>
No labels    </p>
</li><li class="labels-edit-container ">    <p>
<a href="SCOM_Action_Monitoring_Plugin.html">Edit Labels</a>    </p>
</li></ul>    <p>
    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
                </td>
                <td rowspan="1" colspan="1">
        <p>
PNG File                    <a href="https://community/download/attachments/8651084/icon.png?api=v2">icon.png</a>    </p>
            </td>
                <td rowspan="1" colspan="1">
        <p>
Mar 29, 2012by<a href="    /community/display/~wolfgang.gottesheim@compuware.com ">Wolfgang Gottesheim</a>    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
                </td>
                <td rowspan="1" colspan="2">
        <p>
            <img src="images_community/download/attachments/8651084/icon0.png" alt="images_community/download/attachments/8651084/icon0.png" class="confluence-embedded-image" />
            </p>
    <p>
Labels    </p>
<ul class="label-list has-pen "><li class="no-labels-message ">    <p>
No labels    </p>
</li><li class="labels-edit-container ">    <p>
<a href="SCOM_Action_Monitoring_Plugin.html">Edit Labels</a>    </p>
</li></ul>    <p>
    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
                </td>
                <td rowspan="1" colspan="1">
        <p>
ZIP Archive                    <a href="https://community/download/attachments/8651084/dynaTrace_SCOMAlert_v1.0.zip?api=v2">dynaTrace_SCOMAlert_v1.0.zip</a>    </p>
            </td>
                <td rowspan="1" colspan="1">
        <p>
Dec 10, 2008by<a href="    /community/display/~andreas.grabner@compuware.com ">Andreas Grabner</a>    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
                </td>
                <td rowspan="1" colspan="2">
        <p>
    </p>
    <p>
Labels    </p>
<ul class="label-list has-pen "><li class="no-labels-message ">    <p>
No labels    </p>
</li><li class="labels-edit-container ">    <p>
<a href="SCOM_Action_Monitoring_Plugin.html">Edit Labels</a>    </p>
</li></ul>    <p>
    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
                </td>
                <td rowspan="1" colspan="1">
        <p>
File                    <a href="https://community/download/attachments/8651084/plugin_properties.PNG?api=v2">plugin_properties.PNG</a>    </p>
            </td>
                <td rowspan="1" colspan="1">
        <p>
Dec 10, 2008by<a href="    /community/display/~andreas.grabner@compuware.com ">Andreas Grabner</a>    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
                </td>
                <td rowspan="1" colspan="2">
        <p>
            <img src="images_community/download/attachments/8651084/plugin_properties0.PNG" alt="images_community/download/attachments/8651084/plugin_properties0.PNG" class="confluence-embedded-image" />
            </p>
    <p>
Labels    </p>
<ul class="label-list has-pen "><li class="no-labels-message ">    <p>
No labels    </p>
</li><li class="labels-edit-container ">    <p>
<a href="SCOM_Action_Monitoring_Plugin.html">Edit Labels</a>    </p>
</li></ul>    <p>
    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
                </td>
                <td rowspan="1" colspan="1">
        <p>
File                    <a href="https://community/download/attachments/8651084/alerts_in_scom.PNG?api=v2">alerts_in_scom.PNG</a>    </p>
            </td>
                <td rowspan="1" colspan="1">
        <p>
Dec 10, 2008by<a href="    /community/display/~andreas.grabner@compuware.com ">Andreas Grabner</a>    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
                </td>
                <td rowspan="1" colspan="2">
        <p>
            <img src="images_community/download/attachments/8651084/alerts_in_scom0.PNG" alt="images_community/download/attachments/8651084/alerts_in_scom0.PNG" class="confluence-embedded-image" />
            </p>
    <p>
Labels    </p>
<ul class="label-list has-pen "><li class="no-labels-message ">    <p>
No labels    </p>
</li><li class="labels-edit-container ">    <p>
<a href="SCOM_Action_Monitoring_Plugin.html">Edit Labels</a>    </p>
</li></ul>    <p>
    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
                </td>
                <td rowspan="1" colspan="1">
        <p>
File                    <a href="https://community/download/attachments/8651084/managementpacks.PNG?api=v2">managementpacks.PNG</a>    </p>
            </td>
                <td rowspan="1" colspan="1">
        <p>
Dec 10, 2008by<a href="    /community/display/~andreas.grabner@compuware.com ">Andreas Grabner</a>    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
                </td>
                <td rowspan="1" colspan="2">
        <p>
            <img src="images_community/download/attachments/8651084/managementpacks0.PNG" alt="images_community/download/attachments/8651084/managementpacks0.PNG" class="confluence-embedded-image" />
            </p>
    <p>
Labels    </p>
<ul class="label-list has-pen "><li class="no-labels-message ">    <p>
No labels    </p>
</li><li class="labels-edit-container ">    <p>
<a href="SCOM_Action_Monitoring_Plugin.html">Edit Labels</a>    </p>
</li></ul>    <p>
    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
                </td>
                <td rowspan="1" colspan="1">
        <p>
File                    <a href="https://community/download/attachments/8651084/incident%20definition.PNG?api=v2">incident definition.PNG</a>    </p>
            </td>
                <td rowspan="1" colspan="1">
        <p>
Dec 10, 2008by<a href="    /community/display/~andreas.grabner@compuware.com ">Andreas Grabner</a>    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
                </td>
                <td rowspan="1" colspan="2">
        <p>
            <img src="images_community/download/attachments/8651084/incident_definition0.PNG" alt="images_community/download/attachments/8651084/incident_definition0.PNG" class="confluence-embedded-image" />
            </p>
    <p>
Labels    </p>
<ul class="label-list has-pen "><li class="no-labels-message ">    <p>
No labels    </p>
</li><li class="labels-edit-container ">    <p>
<a href="SCOM_Action_Monitoring_Plugin.html">Edit Labels</a>    </p>
</li></ul>    <p>
    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
                </td>
                <td rowspan="1" colspan="1">
        <p>
File                    <a href="https://community/download/attachments/8651084/plugin_import.PNG?api=v2">plugin_import.PNG</a>    </p>
            </td>
                <td rowspan="1" colspan="1">
        <p>
Dec 10, 2008by<a href="    /community/display/~andreas.grabner@compuware.com ">Andreas Grabner</a>    </p>
            </td>
        </tr>
    <tr>
            <td rowspan="1" colspan="1">
                </td>
                <td rowspan="1" colspan="2">
        <p>
            <img src="images_community/download/attachments/8651084/plugin_import0.PNG" alt="images_community/download/attachments/8651084/plugin_import0.PNG" class="confluence-embedded-image" />
            </p>
    <p>
Labels    </p>
<ul class="label-list has-pen "><li class="no-labels-message ">    <p>
No labels    </p>
</li><li class="labels-edit-container ">    <p>
<a href="SCOM_Action_Monitoring_Plugin.html">Edit Labels</a>    </p>
</li></ul>    <p>
    </p>
            </td>
        </tr>
</tbody>        </table>
            </div>
<ul class=" "><li class="drop-zone-text hidden ">    <p>
Drag and drop to upload or browse for files    </p>
            <img src="images_community/images/icons/wait.gif" alt="images_community/images/icons/wait.gif" class="plugin_attachments_dropzone_uploadwaiticon" />
        </li></ul>    <p>
Upload fileFile description<a href="https://community/pages/downloadallattachments.action?pageId=8651084">Download All</a>    </p>
            </div>
        </div>
        <div class="footer">
        </div>
    </div>
</body>
</html>
