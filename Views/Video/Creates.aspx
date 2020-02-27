<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Creates</title>
    <link href="../../Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form action="/Video/Create" method="post">
    
    <fieldset>
    <legend> Datos video </legend> 
    <label for="idvideo"> idvideo </label>
    <input type="text" name="idvideo" />

    <label for="titulo"> titulo </label>
    <input  type="text" name="titulo"/>
    
    <label for="repro"> repro </label>
    <input type="text" name="repro" />
    
    <label for="url" > url</label>
    <input type="text" name="url"/>

    <input type="submit"value="Registrar"/>
    </fieldset>
    <form />
</body>
</html>
