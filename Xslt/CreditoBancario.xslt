<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">
    <html>
      <body>
        <div align="center">
          <h3>Cotización Préstamo</h3>
        </div>
        
        <table>

          <xsl:for-each select="Prestamo">                       

            <tr bgcolor="#990000">
              <th colspan="2" style="color: #fff;">
                <xsl:value-of select="./Banco/@Nombre"/>
              </th>
            </tr>            

            <tr>
              <td>
                <b>Tipo:</b>
              </td>
              <td colspan="2">
                <xsl:value-of select="./Informacion/@Tipo"/>
              </td>
            </tr>

            <tr>
              <td>
                <b>Plazo:</b>
              </td>
              <td colspan="2">
                <xsl:value-of select="./Informacion/@Plazo"/>
              </td>
            </tr>

            <tr>
              <td>
                <b>Moneda:</b>
              </td>
              <td colspan="2">
                <xsl:value-of select="./Informacion/@Moneda"/>
              </td>
            </tr>

            <tr>
              <td>
                <b>Monto:</b>
              </td>
              <td colspan="2">
                <xsl:value-of select="./Informacion/Monto"/>
              </td>
            </tr>


            <tr>
              <td>
                <b>Prima:</b>
              </td>
              <td colspan="2">
                <xsl:value-of select="./Informacion/Prima"/>
              </td>
            </tr>

            <tr bgcolor="#FF6666">
              <th colspan="2">Cliente</th>
            </tr>
            <tr>
              <td>
                <b>Identificacion:</b>
              </td>
              <td colspan="2">
                <xsl:value-of select="./Cliente/@Identificacion"/>
              </td>
            </tr>
            <tr>
              <td>
                <b>Nombre:</b>
              </td>
              <td colspan="2">
                <xsl:value-of select="./Cliente/@Nombre"/>
              </td>
            </tr>
            <tr>
              <td>
                <b>Teléfono:</b>
              </td>
              <td colspan="2">
                <xsl:value-of select="./Cliente/@Telefono"/>
              </td>
            </tr>
            <tr>
              <td>
                <b>Ingreso:</b>
              </td>
              <td colspan="2">
                <xsl:value-of select="./Cliente/IngresoMinimo"/>
              </td>
            </tr>
           
           

            <tr bgcolor="#FF6666">
              <th colspan="2">Gastos</th>
            </tr>
            <xsl:for-each select="./Gastos/OtroGasto">
              <tr>
                <td colspan="2">
                  <xsl:value-of select="."/>
                  <br/>
                  <b>Monto:&#160;</b>
                  <xsl:value-of select="./@Monto"/>
                </td>
              </tr>
            </xsl:for-each>

            <tr>
              <td>
                <b>Total gastos:</b>
              </td>
              <td colspan="2">
                <xsl:value-of select="./TotalGastos"/>
              </td>
            </tr>

            <tr bgcolor="#FF6666">
              <th colspan="2">Cuotas</th>
            </tr>
            <xsl:for-each select="./Cuotas/Cuota">
              <tr>
                <td>
                  <xsl:value-of select="."/>
                </td>
                <td>
                  <b>Monto:&#160;</b>
                  <xsl:value-of select="./@Monto"/>
                </td>
              </tr>
            </xsl:for-each>

          </xsl:for-each>

        </table>
      </body>
    </html>
  </xsl:template>

</xsl:stylesheet>