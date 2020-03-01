<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Borrar</title>
</head>
<body>
    <h1> Borrar video </h1>
    <form action= "/Video/Delete" method="post"
    <fieldset>
    <label for="idvideo"> idvideo </label>
    <input type="text" name="idvideo" />

    <input type="submit"value="Borrar"/>
    </fieldset>
    
    </form>
</body>
</html>
