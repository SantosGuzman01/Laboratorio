<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Modificar</title>
</head>
<body>
    <form action="/Video/Update" method="post">
    <fieldset>
    <label for="idvideo"> idvideo </label>
    <input type="text" name="idvideo" />

    <label for="titulo"> titulo </label>
    <input  type="text" name="titulo"/>
    
    <label for="repro"> repro </label>
    <input type="text" name="repro" />
    
    <label for="url" > url</label>
    <input type="text" name="url"/>

    <input type="submit"value="Modificar"/>
    </fieldset>
    </form>
</body>
</html>
