using PocSII.DteProcessor.Common;


namespace PocSII.DteSender.Tests.Common {
    public class XmlValidatorTests {
        [Fact]
        public void ValidateXml_ValidXml_ReturnsSuccess() {
            // Arrange
            string validXml = @"<?xml version=""1.0"" encoding=""iso-8859-1""?>
<EnvioDTE xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" version=""1.0"" xmlns=""http://www.sii.cl/SiiDte"">
  <SetDTE ID=""SetDoc"">
    <Caratula version=""1.0"">
      <RutEmisor>97975000-5</RutEmisor>
      <RutEnvia>97975000-5</RutEnvia>
      <RutReceptor>77777777-7</RutReceptor>
      <FchResol>2003-09-02</FchResol>
      <NroResol>0</NroResol>
      <TmstFirmaEnv>2025-04-08T15:50:16.1844283-05:00</TmstFirmaEnv>
      <SubTotDTE>
        <TpoDTE>33</TpoDTE>
        <NroDTE>1</NroDTE>
      </SubTotDTE>
    </Caratula>
    <DTE version=""1.0"">
      <Documento ID=""F60T33"">
        <Encabezado>
          <IdDoc>
            <TipoDTE>33</TipoDTE>
            <Folio>60</Folio>
            <FchEmis>2025-04-08</FchEmis>
          </IdDoc>
          <Emisor>
            <RUTEmisor>97975000-5</RUTEmisor>
            <RznSoc>RUT DE PRUEBA</RznSoc>
            <GiroEmis>Insumos de Computacion</GiroEmis>
            <Acteco>31341</Acteco>
            <CdgSIISucur>1234</CdgSIISucur>
            <DirOrigen>Teatinos 120, Piso 4</DirOrigen>
            <CmnaOrigen>Santiago</CmnaOrigen>
            <CiudadOrigen>Santiago</CiudadOrigen>
          </Emisor>
          <Receptor>
            <RUTRecep>77777777-7</RUTRecep>
            <RznSocRecep>EMPRESA LTDA</RznSocRecep>
            <GiroRecep>COMPUTACION</GiroRecep>
            <DirRecep>SAN DIEGO 2222</DirRecep>
            <CmnaRecep>Santiago</CmnaRecep>
            <CiudadRecep>Santiago</CiudadRecep>
          </Receptor>
          <Totales>
            <MntNeto>100000</MntNeto>
            <TasaIVA>19</TasaIVA>
            <IVA>19</IVA>
            <MntTotal>119000</MntTotal>
          </Totales>
        </Encabezado>
        <Detalle>
          <NroLinDet>1</NroLinDet>
          <CdgItem>
            <TpoCodigo>INT1</TpoCodigo>
            <VlrCodigo>001</VlrCodigo>
          </CdgItem>
          <NmbItem>Parlantes Multimedia 180W</NmbItem>
          <QtyItem>20</QtyItem>
          <PrcItem>4500</PrcItem>
          <MontoItem>90000</MontoItem>
        </Detalle>
        <Detalle>
          <NroLinDet>2</NroLinDet>
          <CdgItem>
            <TpoCodigo>INT1</TpoCodigo>
            <VlrCodigo>1515</VlrCodigo>
          </CdgItem>
          <NmbItem>Caja de Diskettes 10 Unidades</NmbItem>
          <QtyItem>5</QtyItem>
          <PrcItem>1000</PrcItem>
          <MontoItem>5000</MontoItem>
        </Detalle>
        <TED version=""1.0"">
          <DD>
            <RE>97975000-5</RE>
            <TD>33</TD>
            <F>60</F>
            <FE>2025-04-08</FE>
            <RR>77777777-7</RR>
            <RSR>EMPRESA LTDA</RSR>
            <MNT>119000</MNT>
            <IT1>Parlantes Multimedia 180W</IT1>
            <CAF version=""1.0"">
              <DA>
                <RE>97975000-5</RE>
                <RS>RUT DE PRUEBA</RS>
                <TD>33</TD>
                <RNG>
                  <D>1</D>
                  <H>200</H>
                </RNG>
                <FA>2003-09-04</FA>
                <RSAPK>
                  <M>0a4O6Kbx8Qj3K4iWSP4w7KneZYeJ+g/prihYtIEolKt3cykSxl1zO8vSXu397QhTmsX7SBEudTUx++2zDXBhZw==</M>
                  <E>Aw==</E>
                </RSAPK>
                <IDK>100</IDK>
              </DA>
              <FRMA algoritmo=""SHA1withRSA"">g1AQX0sy8NJugX52k2hTJEZAE9Cuul6pqYBdFxj1N17umW7zG/hAavCALKByHzdYAfZ3LhGTXCai5zNxOo4lDQ==</FRMA>
            </CAF>
            <TSTED>2025-04-08T15:50:15.0353398-05:00</TSTED>
          </DD>
          <FRMT algoritmo=""SHA1withRSA"">GbmDcS9e/jVC2LsLIe1iRV12Bf6lxsILtbQiCkh6mbjckFCJ7fj/kakFTS06Jo8iS4HXvJj3oYZuey53Krniew==</FRMT>
        </TED>
        <TmstFirma>2025-04-08T15:50:15.0353398-05:00</TmstFirma>
      </Documento>
    </DTE>
  </SetDTE>
</EnvioDTE>";

            // Act
            var result = XmlValidator.ValidateXml(validXml);

            // Assert
            Assert.True(result.IsSuccess);
            Assert.True(result.Value);
        }

        [Fact]
        public void ValidateXml_InvalidXml_ReturnsFailure() {
            // Arrange
            string invalidXml = @"<EnvioDTE xmlns=""http://www.sii.cl/SiiDte"">
                                    <DTE>
                                        <Documento>
                                            <Encabezado>
                                                <!-- Missing required elements -->
                                            </Encabezado>
                                        </Documento>
                                    </DTE>
                                </EnvioDTE>";

            // Act
            var result = XmlValidator.ValidateXml(invalidXml);

            // Assert
            Assert.False(result.IsSuccess);
        }

        [Fact]
        public void ValidateXml_MalformedXml_ReturnsFailure() {
            // Arrange
            string malformedXml = @"<EnvioDTE xmlns=""http://www.sii.cl/SiiDte"">
                                    <DTE>
                                        <Documento>
                                            <Encabezado>
                                                <IdDoc></IdDoc>
                                            </Encabezado>
                                        </Documento>
                                    </DTE>";

            // Act
            var result = XmlValidator.ValidateXml(malformedXml);

            // Assert
            Assert.False(result.IsSuccess);
        }

    }
}