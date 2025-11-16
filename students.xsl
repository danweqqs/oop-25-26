<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

    <xsl:template match="/">
        <html>
            <body>
                <h2>Успішність студентів</h2>
                <table border="1">
                    <tr>
                        <th>ПІБ</th>
                        <th>Факультет</th>
                        <th>Предмет</th>
                        <th>Оцінка</th>
                        <th>Викладач</th>
                    </tr>

                    <xsl:for-each select="students/student">
                        <xsl:variable name="name" select="name" />
                        <xsl:variable name="faculty" select="@faculty" />

                        <xsl:for-each select="credits/subject | exams/subject">
                            <tr>
                                <td>
                                    <xsl:value-of select="$name" />
                                </td>
                                <td>
                                    <xsl:value-of select="$faculty" />
                                </td>
                                <td>
                                    <xsl:value-of select="." />
                                </td>
                                <td>
                                    <xsl:value-of select="@score" />
                                </td>
                                <td>
                                    <xsl:value-of select="@teacher"/>
                                </td>
                            </tr>
                        </xsl:for-each>
                    </xsl:for-each>

                </table>
            </body>
        </html>
    </xsl:template>

</xsl:stylesheet>