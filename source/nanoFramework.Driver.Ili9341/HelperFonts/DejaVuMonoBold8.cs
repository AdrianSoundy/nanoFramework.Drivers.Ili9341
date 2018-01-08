namespace NanoFramework.Driver.Ili9341.HelperFonts
{
    public static class DejaVuMonoBold8
    {
        public static readonly byte FontSpace = 0;
        public static readonly byte Height = 12;

        public static byte[] Bitmaps
        {
            get
            {
                return new byte[] {
        /* @0 ' ' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @12 '!' (8 pixels wide) */
        0x00, /*          */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x00, /*          */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @24 '"' (8 pixels wide) */
        0x00, /*          */
        0x28, /*   # #    */
        0x28, /*   # #    */
        0x28, /*   # #    */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @36 '#' (8 pixels wide) */
        0x00, /*          */
        0x14, /*    # #   */
        0x34, /*   ## #   */
        0x7E, /*  ######  */
        0x28, /*   # #    */
        0x28, /*   # #    */
        0xFC, /* ######   */
        0x58, /*  # ##    */
        0x50, /*  # #     */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @48 '$' (8 pixels wide) */
        0x00, /*          */
        0x10, /*    #     */
        0x38, /*   ###    */
        0x50, /*  # #     */
        0x78, /*  ####    */
        0x3C, /*   ####   */
        0x14, /*    # #   */
        0x54, /*  # # #   */
        0x38, /*   ###    */
        0x10, /*    #     */
        0x10, /*    #     */
        0x00, /*          */

        /* @60 '%' (8 pixels wide) */
        0x00, /*          */
        0xE0, /* ###      */
        0xA0, /* # #      */
        0xE4, /* ###  #   */
        0x18, /*    ##    */
        0x20, /*   #      */
        0xDC, /* ## ###   */
        0x14, /*    # #   */
        0x1C, /*    ###   */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @72 '&' (8 pixels wide) */
        0x00, /*          */
        0x38, /*   ###    */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x10, /*    #     */
        0x7A, /*  #### #  */
        0x6A, /*  ## # #  */
        0x6E, /*  ## ###  */
        0x3E, /*   #####  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @84 ''' (8 pixels wide) */
        0x00, /*          */
        0x10, /*    #     */
        0x10, /*    #     */
        0x10, /*    #     */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @96 '(' (8 pixels wide) */
        0x08, /*     #    */
        0x18, /*    ##    */
        0x10, /*    #     */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x10, /*    #     */
        0x18, /*    ##    */
        0x08, /*     #    */
        0x00, /*          */
        0x00, /*          */

        /* @108 ')' (8 pixels wide) */
        0x20, /*   #      */
        0x30, /*   ##     */
        0x10, /*    #     */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x10, /*    #     */
        0x30, /*   ##     */
        0x20, /*   #      */
        0x00, /*          */
        0x00, /*          */

        /* @120 '*' (8 pixels wide) */
        0x00, /*          */
        0x10, /*    #     */
        0x54, /*  # # #   */
        0x38, /*   ###    */
        0x38, /*   ###    */
        0x54, /*  # # #   */
        0x10, /*    #     */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @132 '+' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x10, /*    #     */
        0x10, /*    #     */
        0x7C, /*  #####   */
        0x10, /*    #     */
        0x10, /*    #     */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @144 ',' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x20, /*   #      */
        0x40, /*  #       */
        0x00, /*          */

        /* @156 '-' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x38, /*   ###    */
        0x38, /*   ###    */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @168 '.' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @180 '/' (8 pixels wide) */
        0x00, /*          */
        0x04, /*      #   */
        0x08, /*     #    */
        0x08, /*     #    */
        0x10, /*    #     */
        0x10, /*    #     */
        0x10, /*    #     */
        0x20, /*   #      */
        0x20, /*   #      */
        0x40, /*  #       */
        0x00, /*          */
        0x00, /*          */

        /* @192 '0' (8 pixels wide) */
        0x00, /*          */
        0x3C, /*   ####   */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x6E, /*  ## ###  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x3C, /*   ####   */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @204 '1' (8 pixels wide) */
        0x00, /*          */
        0x78, /*  ####    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x7E, /*  ######  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @216 '2' (8 pixels wide) */
        0x00, /*          */
        0x7C, /*  #####   */
        0x06, /*      ##  */
        0x06, /*      ##  */
        0x0C, /*     ##   */
        0x08, /*     #    */
        0x10, /*    #     */
        0x20, /*   #      */
        0x7E, /*  ######  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @228 '3' (8 pixels wide) */
        0x00, /*          */
        0x7C, /*  #####   */
        0x06, /*      ##  */
        0x06, /*      ##  */
        0x38, /*   ###    */
        0x06, /*      ##  */
        0x06, /*      ##  */
        0x06, /*      ##  */
        0x7C, /*  #####   */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @240 '4' (8 pixels wide) */
        0x00, /*          */
        0x0C, /*     ##   */
        0x1C, /*    ###   */
        0x3C, /*   ####   */
        0x2C, /*   # ##   */
        0x4C, /*  #  ##   */
        0x7E, /*  ######  */
        0x0C, /*     ##   */
        0x0C, /*     ##   */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @252 '5' (8 pixels wide) */
        0x00, /*          */
        0x7E, /*  ######  */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x7C, /*  #####   */
        0x06, /*      ##  */
        0x06, /*      ##  */
        0x06, /*      ##  */
        0x7C, /*  #####   */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @264 '6' (8 pixels wide) */
        0x00, /*          */
        0x3C, /*   ####   */
        0x30, /*   ##     */
        0x60, /*  ##      */
        0x7C, /*  #####   */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x3C, /*   ####   */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @276 '7' (8 pixels wide) */
        0x00, /*          */
        0x7E, /*  ######  */
        0x06, /*      ##  */
        0x0C, /*     ##   */
        0x0C, /*     ##   */
        0x1C, /*    ###   */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x30, /*   ##     */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @288 '8' (8 pixels wide) */
        0x00, /*          */
        0x3C, /*   ####   */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x18, /*    ##    */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x3C, /*   ####   */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @300 '9' (8 pixels wide) */
        0x00, /*          */
        0x3C, /*   ####   */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x3E, /*   #####  */
        0x06, /*      ##  */
        0x0E, /*     ###  */
        0x3C, /*   ####   */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @312 ':' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x00, /*          */
        0x00, /*          */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @324 ';' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x00, /*          */
        0x00, /*          */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x20, /*   #      */
        0x40, /*  #       */
        0x00, /*          */

        /* @336 '<' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x02, /*       #  */
        0x1E, /*    ####  */
        0x70, /*  ###     */
        0x70, /*  ###     */
        0x1E, /*    ####  */
        0x02, /*       #  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @348 '=' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x7E, /*  ######  */
        0x00, /*          */
        0x7E, /*  ######  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @360 '>' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x40, /*  #       */
        0x78, /*  ####    */
        0x0E, /*     ###  */
        0x0E, /*     ###  */
        0x78, /*  ####    */
        0x40, /*  #       */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @372 '?' (8 pixels wide) */
        0x00, /*          */
        0x38, /*   ###    */
        0x58, /*  # ##    */
        0x18, /*    ##    */
        0x20, /*   #      */
        0x30, /*   ##     */
        0x00, /*          */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @384 '@' (8 pixels wide) */
        0x00, /*          */
        0x38, /*   ###    */
        0x44, /*  #   #   */
        0x9C, /* #  ###   */
        0xA4, /* # #  #   */
        0xA4, /* # #  #   */
        0xA4, /* # #  #   */
        0x9C, /* #  ###   */
        0x44, /*  #   #   */
        0x3C, /*   ####   */
        0x00, /*          */
        0x00, /*          */

        /* @396 'A' (8 pixels wide) */
        0x00, /*          */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x3C, /*   ####   */
        0x3C, /*   ####   */
        0x24, /*   #  #   */
        0x3C, /*   ####   */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @408 'B' (8 pixels wide) */
        0x00, /*          */
        0x7C, /*  #####   */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x78, /*  ####    */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x7C, /*  #####   */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @420 'C' (8 pixels wide) */
        0x00, /*          */
        0x1C, /*    ###   */
        0x32, /*   ##  #  */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x32, /*   ##  #  */
        0x1C, /*    ###   */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @432 'D' (8 pixels wide) */
        0x00, /*          */
        0x7C, /*  #####   */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x7C, /*  #####   */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @444 'E' (8 pixels wide) */
        0x00, /*          */
        0x7E, /*  ######  */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x7C, /*  #####   */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x7E, /*  ######  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @456 'F' (8 pixels wide) */
        0x00, /*          */
        0x7E, /*  ######  */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x7C, /*  #####   */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @468 'G' (8 pixels wide) */
        0x00, /*          */
        0x1C, /*    ###   */
        0x32, /*   ##  #  */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x6E, /*  ## ###  */
        0x66, /*  ##  ##  */
        0x36, /*   ## ##  */
        0x1E, /*    ####  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @480 'H' (8 pixels wide) */
        0x00, /*          */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x7E, /*  ######  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @492 'I' (8 pixels wide) */
        0x00, /*          */
        0x7E, /*  ######  */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x7E, /*  ######  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @504 'J' (8 pixels wide) */
        0x00, /*          */
        0x1E, /*    ####  */
        0x06, /*      ##  */
        0x06, /*      ##  */
        0x06, /*      ##  */
        0x06, /*      ##  */
        0x06, /*      ##  */
        0x46, /*  #   ##  */
        0x3C, /*   ####   */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @516 'K' (8 pixels wide) */
        0x00, /*          */
        0x66, /*  ##  ##  */
        0x6C, /*  ## ##   */
        0x68, /*  ## #    */
        0x78, /*  ####    */
        0x78, /*  ####    */
        0x6C, /*  ## ##   */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @528 'L' (8 pixels wide) */
        0x00, /*          */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x7E, /*  ######  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @540 'M' (8 pixels wide) */
        0x00, /*          */
        0x42, /*  #    #  */
        0x66, /*  ##  ##  */
        0x7E, /*  ######  */
        0x7E, /*  ######  */
        0x7E, /*  ######  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @552 'N' (8 pixels wide) */
        0x00, /*          */
        0x66, /*  ##  ##  */
        0x76, /*  ### ##  */
        0x76, /*  ### ##  */
        0x76, /*  ### ##  */
        0x6E, /*  ## ###  */
        0x6E, /*  ## ###  */
        0x6E, /*  ## ###  */
        0x66, /*  ##  ##  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @564 'O' (8 pixels wide) */
        0x00, /*          */
        0x3C, /*   ####   */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x3C, /*   ####   */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @576 'P' (8 pixels wide) */
        0x00, /*          */
        0x7C, /*  #####   */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x7C, /*  #####   */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @588 'Q' (8 pixels wide) */
        0x00, /*          */
        0x3C, /*   ####   */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x3C, /*   ####   */
        0x04, /*      #   */
        0x00, /*          */
        0x00, /*          */

        /* @600 'R' (8 pixels wide) */
        0x00, /*          */
        0x7C, /*  #####   */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x78, /*  ####    */
        0x64, /*  ##  #   */
        0x66, /*  ##  ##  */
        0x63, /*  ##   ## */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @612 'S' (8 pixels wide) */
        0x00, /*          */
        0x3C, /*   ####   */
        0x62, /*  ##   #  */
        0x60, /*  ##      */
        0x78, /*  ####    */
        0x1E, /*    ####  */
        0x06, /*      ##  */
        0x46, /*  #   ##  */
        0x3C, /*   ####   */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @624 'T' (8 pixels wide) */
        0x00, /*          */
        0x7E, /*  ######  */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @636 'U' (8 pixels wide) */
        0x00, /*          */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x3C, /*   ####   */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @648 'V' (8 pixels wide) */
        0x00, /*          */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x24, /*   #  #   */
        0x24, /*   #  #   */
        0x3C, /*   ####   */
        0x3C, /*   ####   */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @660 'W' (8 pixels wide) */
        0x00, /*          */
        0xC6, /* ##   ##  */
        0xC6, /* ##   ##  */
        0xD6, /* ## # ##  */
        0xD6, /* ## # ##  */
        0x6C, /*  ## ##   */
        0x6C, /*  ## ##   */
        0x6C, /*  ## ##   */
        0x6C, /*  ## ##   */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @672 'X' (8 pixels wide) */
        0x00, /*          */
        0x66, /*  ##  ##  */
        0x24, /*   #  #   */
        0x3C, /*   ####   */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x3C, /*   ####   */
        0x24, /*   #  #   */
        0x66, /*  ##  ##  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @684 'Y' (8 pixels wide) */
        0x00, /*          */
        0x66, /*  ##  ##  */
        0x24, /*   #  #   */
        0x3C, /*   ####   */
        0x3C, /*   ####   */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @696 'Z' (8 pixels wide) */
        0x00, /*          */
        0x7E, /*  ######  */
        0x06, /*      ##  */
        0x0C, /*     ##   */
        0x18, /*    ##    */
        0x10, /*    #     */
        0x30, /*   ##     */
        0x60, /*  ##      */
        0x7E, /*  ######  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @708 '[' (8 pixels wide) */
        0x38, /*   ###    */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x38, /*   ###    */
        0x00, /*          */
        0x00, /*          */

        /* @720 '\' (8 pixels wide) */
        0x00, /*          */
        0x40, /*  #       */
        0x20, /*   #      */
        0x20, /*   #      */
        0x10, /*    #     */
        0x10, /*    #     */
        0x10, /*    #     */
        0x08, /*     #    */
        0x08, /*     #    */
        0x04, /*      #   */
        0x00, /*          */
        0x00, /*          */

        /* @732 ']' (8 pixels wide) */
        0x38, /*   ###    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x38, /*   ###    */
        0x00, /*          */
        0x00, /*          */

        /* @744 '^' (8 pixels wide) */
        0x00, /*          */
        0x30, /*   ##     */
        0x78, /*  ####    */
        0xCC, /* ##  ##   */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @756 '_' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0xFE, /* #######  */

        /* @768 '`' (8 pixels wide) */
        0x60, /*  ##      */
        0x30, /*   ##     */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @780 'a' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x3C, /*   ####   */
        0x06, /*      ##  */
        0x3E, /*   #####  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x3E, /*   #####  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @792 'b' (8 pixels wide) */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x7C, /*  #####   */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x7C, /*  #####   */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @804 'c' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x3E, /*   #####  */
        0x70, /*  ###     */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x70, /*  ###     */
        0x3E, /*   #####  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @816 'd' (8 pixels wide) */
        0x06, /*      ##  */
        0x06, /*      ##  */
        0x06, /*      ##  */
        0x3E, /*   #####  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x3E, /*   #####  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @828 'e' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x3C, /*   ####   */
        0x66, /*  ##  ##  */
        0x7E, /*  ######  */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x3E, /*   #####  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @840 'f' (8 pixels wide) */
        0x1C, /*    ###   */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x7C, /*  #####   */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @852 'g' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x3E, /*   #####  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x3E, /*   #####  */
        0x06, /*      ##  */
        0x3C, /*   ####   */
        0x00, /*          */

        /* @864 'h' (8 pixels wide) */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x7C, /*  #####   */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @876 'i' (8 pixels wide) */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x00, /*          */
        0x78, /*  ####    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x7E, /*  ######  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @888 'j' (8 pixels wide) */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x00, /*          */
        0x78, /*  ####    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x70, /*  ###     */
        0x00, /*          */

        /* @900 'k' (8 pixels wide) */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x6C, /*  ## ##   */
        0x68, /*  ## #    */
        0x78, /*  ####    */
        0x68, /*  ## #    */
        0x6C, /*  ## ##   */
        0x66, /*  ##  ##  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @912 'l' (8 pixels wide) */
        0xF0, /* ####     */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x1C, /*    ###   */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @924 'm' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x7E, /*  ######  */
        0x6A, /*  ## # #  */
        0x6A, /*  ## # #  */
        0x6A, /*  ## # #  */
        0x6A, /*  ## # #  */
        0x6A, /*  ## # #  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @936 'n' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x7C, /*  #####   */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @948 'o' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x3C, /*   ####   */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x3C, /*   ####   */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @960 'p' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x7C, /*  #####   */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x7C, /*  #####   */
        0x60, /*  ##      */
        0x60, /*  ##      */
        0x00, /*          */

        /* @972 'q' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x3E, /*   #####  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x3E, /*   #####  */
        0x06, /*      ##  */
        0x06, /*      ##  */
        0x00, /*          */

        /* @984 'r' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x3E, /*   #####  */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @996 's' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x3C, /*   ####   */
        0x62, /*  ##   #  */
        0x78, /*  ####    */
        0x1E, /*    ####  */
        0x46, /*  #   ##  */
        0x3C, /*   ####   */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @1008 't' (8 pixels wide) */
        0x00, /*          */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0xFC, /* ######   */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x30, /*   ##     */
        0x3C, /*   ####   */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @1020 'u' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x3E, /*   #####  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @1032 'v' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x66, /*  ##  ##  */
        0x66, /*  ##  ##  */
        0x24, /*   #  #   */
        0x3C, /*   ####   */
        0x3C, /*   ####   */
        0x18, /*    ##    */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @1044 'w' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0xC6, /* ##   ##  */
        0xC6, /* ##   ##  */
        0x54, /*  # # #   */
        0x6C, /*  ## ##   */
        0x6C, /*  ## ##   */
        0x6C, /*  ## ##   */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @1056 'x' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x66, /*  ##  ##  */
        0x3C, /*   ####   */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x3C, /*   ####   */
        0x66, /*  ##  ##  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @1068 'y' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x66, /*  ##  ##  */
        0x24, /*   #  #   */
        0x2C, /*   # ##   */
        0x3C, /*   ####   */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x10, /*    #     */
        0x70, /*  ###     */
        0x00, /*          */

        /* @1080 'z' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x7E, /*  ######  */
        0x06, /*      ##  */
        0x0C, /*     ##   */
        0x30, /*   ##     */
        0x60, /*  ##      */
        0x7E, /*  ######  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */

        /* @1092 '{' (8 pixels wide) */
        0x1E, /*    ####  */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x60, /*  ##      */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x1E, /*    ####  */
        0x00, /*          */
        0x00, /*          */

        /* @1104 '|' (8 pixels wide) */
        0x10, /*    #     */
        0x10, /*    #     */
        0x10, /*    #     */
        0x10, /*    #     */
        0x10, /*    #     */
        0x10, /*    #     */
        0x10, /*    #     */
        0x10, /*    #     */
        0x10, /*    #     */
        0x10, /*    #     */
        0x10, /*    #     */
        0x00, /*          */

        /* @1116 '}' (8 pixels wide) */
        0x78, /*  ####    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x06, /*      ##  */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x18, /*    ##    */
        0x78, /*  ####    */
        0x00, /*          */
        0x00, /*          */

        /* @1128 '~' (8 pixels wide) */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x70, /*  ###     */
        0x0E, /*     ###  */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        0x00, /*          */
        };
            }
        }

        public static ushort[] Descriptors
        {
            get
            {
                return new ushort[] {
        8, 0, 		/*   */ 
        8, 12, 		/* ! */ 
        8, 24, 		/* " */ 
        8, 36, 		/* # */ 
        8, 48, 		/* $ */ 
        8, 60, 		/* % */ 
        8, 72, 		/* & */ 
        8, 84, 		/* ' */ 
        8, 96, 		/* ( */ 
        8, 108, 		/* ) */ 
        8, 120, 		/* * */ 
        8, 132, 		/* + */ 
        8, 144, 		/* , */ 
        8, 156, 		/* - */ 
        8, 168, 		/* . */ 
        8, 180, 		/* / */ 
        8, 192, 		/* 0 */ 
        8, 204, 		/* 1 */ 
        8, 216, 		/* 2 */ 
        8, 228, 		/* 3 */ 
        8, 240, 		/* 4 */ 
        8, 252, 		/* 5 */ 
        8, 264, 		/* 6 */ 
        8, 276, 		/* 7 */ 
        8, 288, 		/* 8 */ 
        8, 300, 		/* 9 */ 
        8, 312, 		/* : */ 
        8, 324, 		/* ; */ 
        8, 336, 		/* < */ 
        8, 348, 		/* = */ 
        8, 360, 		/* > */ 
        8, 372, 		/* ? */ 
        8, 384, 		/* @ */ 
        8, 396, 		/* A */ 
        8, 408, 		/* B */ 
        8, 420, 		/* C */ 
        8, 432, 		/* D */ 
        8, 444, 		/* E */ 
        8, 456, 		/* F */ 
        8, 468, 		/* G */ 
        8, 480, 		/* H */ 
        8, 492, 		/* I */ 
        8, 504, 		/* J */ 
        8, 516, 		/* K */ 
        8, 528, 		/* L */ 
        8, 540, 		/* M */ 
        8, 552, 		/* N */ 
        8, 564, 		/* O */ 
        8, 576, 		/* P */ 
        8, 588, 		/* Q */ 
        8, 600, 		/* R */ 
        8, 612, 		/* S */ 
        8, 624, 		/* T */ 
        8, 636, 		/* U */ 
        8, 648, 		/* V */ 
        8, 660, 		/* W */ 
        8, 672, 		/* X */ 
        8, 684, 		/* Y */ 
        8, 696, 		/* Z */ 
        8, 708, 		/* [ */ 
        8, 720, 		/* \ */ 
        8, 732, 		/* ] */ 
        8, 744, 		/* ^ */ 
        8, 756, 		/* _ */ 
        8, 768, 		/* ` */ 
        8, 780, 		/* a */ 
        8, 792, 		/* b */ 
        8, 804, 		/* c */ 
        8, 816, 		/* d */ 
        8, 828, 		/* e */ 
        8, 840, 		/* f */ 
        8, 852, 		/* g */ 
        8, 864, 		/* h */ 
        8, 876, 		/* i */ 
        8, 888, 		/* j */ 
        8, 900, 		/* k */ 
        8, 912, 		/* l */ 
        8, 924, 		/* m */ 
        8, 936, 		/* n */ 
        8, 948, 		/* o */ 
        8, 960, 		/* p */ 
        8, 972, 		/* q */ 
        8, 984, 		/* r */ 
        8, 996, 		/* s */ 
        8, 1008, 		/* t */ 
        8, 1020, 		/* u */ 
        8, 1032, 		/* v */ 
        8, 1044, 		/* w */ 
        8, 1056, 		/* x */ 
        8, 1068, 		/* y */ 
        8, 1080, 		/* z */ 
        8, 1092, 		/* { */ 
        8, 1104, 		/* | */ 
        8, 1116, 		/* } */ 
        8, 1128 		/* ~ */
        };
            }
        }
    }
}