using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace JailbreakDestroyer
{
	// Token: 0x02000005 RID: 5
	public partial class Languages : Form
	{
		// Token: 0x06000012 RID: 18 RVA: 0x000023C9 File Offset: 0x000005C9
		public Languages(Form3 form1)
		{
			this.InitializeComponent();
			this.lan = form1;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000023E8 File Offset: 0x000005E8
		private void button1_Click(object sender, EventArgs e)
		{
			this.lan.flatButton1.Text = "Inyectar";
			this.lan.flatLabel1.Text = "¡Suscríbete a Nonsense Diamond en Youtube Para Obtener más \nactualizaciones!";
			this.lan.flatLabel3.Text = "ESTADO:";
			this.lan.flatButton86.Text = "⮎ Ir al sitio web";
			this.lan.flatButton27.Text = "Buscar Actualizaciones✔";
			this.lan.flatButton3.Text = "➼ Unirse a sorteos";
			this.lan.flatButton2.Text = "Suscríbete ☺ ";
			this.lan.flatButton21.Text = "Ejecutar";
			this.lan.flatButton38.Text = "Borrar";
			this.lan.flatButton41.Text = "Abrir";
			this.lan.checkBox1.Text = "Arco Iris";
			this.lan.label1.Text = "Cambiar Color";
			this.lan.flatButton137.Text = "Verde";
			this.lan.flatButton139.Text = "Azul";
			this.lan.flatButton149.Text = "Negro";
			this.lan.flatButton140.Text = "Naranja";
			this.lan.flatButton141.Text = "Rojo";
			this.lan.flatButton148.Text = "Gris";
			this.lan.flatButton142.Text = "Verde Azulado";
			this.lan.flatButton143.Text = "Dorado";
			this.lan.flatButton147.Text = "Rosa";
			this.lan.flatButton144.Text = "Defecto(Morado)";
			this.lan.flatButton145.Text = "Cadete Azul";
			this.lan.flatButton146.Text = "Azul Cielo";
			this.lan.checkBox3.Text = "La Cima";
			this.lan.flatButton151.Text = "Cerrar Roblox";
			this.lan.flatButton229.Text = "Clic Para Elegir El Idioma";
			this.lan.flatButton115.Text = "Inicio";
			this.lan.flatButton245.Text = "Sevidores De Vip";
			this.lan.flatButton247.Text = "Adjustes";
			this.lan.label6.Text = "Cambios:";
			this.lan.richTextBox40.Text = "Fecha: 25/11/2018 (¡Feliz Navidad! Para la mayoría de las personas)\r\n-------------------------------------------\r\n-Tema de Navidad añadido\r\n- Añadido un montón de nuevos juegos.\r\nFecha: 30/11/2018\r\n--------------------------------------------\r\n- Añadido un nuevo idioma(polaco)\r\nFecha: 16/11/2018\r\n--------------------------------------------\r\n- ¡Añadidos más juegos!\r\nx botones muertos eliminados:^)\r\nFecha: 21/10/2018\r\n--------------------------------------------\r\n- Más estabilidad\r\n- Prueba otros scripts y úsalo en Full Lua\r\n- Aumento de la velocidad de inyección!\r\nx Implementé una solución para la mayoría de las inyecciones.\r\nFecha: 13 / 10 / 2018\r\n--------------------------------------------\r\n- Añadido Pocos Más CMDS\r\n- Compatibilidad completa con Lua agregada\r\n- Más rápido y seguro\r\n- Idiomas añadidos(alemán, italiano, francés y ruso)\r\nx Eliminado todos los CMDS no deseados(parcheados)";
			this.lan.formSkin1.Refresh();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000026C8 File Offset: 0x000008C8
		private void button2_Click(object sender, EventArgs e)
		{
			this.lan.flatButton1.Text = "Inject";
			this.lan.flatLabel1.Text = "Subscribe to Nonsense Diamond On Youtube For More Updates!";
			this.lan.flatLabel3.Text = "STATUS:";
			this.lan.flatButton86.Text = "⮎ Visit Website";
			this.lan.flatButton27.Text = "Check For Updates✔";
			this.lan.flatButton3.Text = "➼ Click To Join Giveaways";
			this.lan.flatButton2.Text = "Click To Subscribe ☺ ";
			this.lan.flatButton21.Text = "Execute";
			this.lan.flatButton38.Text = "Clear";
			this.lan.flatButton41.Text = "Open";
			this.lan.checkBox1.Text = "Rainbow";
			this.lan.label1.Text = "Change Colour";
			this.lan.flatButton137.Text = "Green";
			this.lan.flatButton139.Text = "Blue";
			this.lan.flatButton149.Text = "Black";
			this.lan.flatButton140.Text = "Orange";
			this.lan.flatButton141.Text = "Red";
			this.lan.flatButton148.Text = "Gray";
			this.lan.flatButton142.Text = "Teal";
			this.lan.flatButton143.Text = "Gold";
			this.lan.flatButton147.Text = "Pink";
			this.lan.flatButton144.Text = "Default(Purple)";
			this.lan.flatButton145.Text = "Cadet Blue";
			this.lan.flatButton146.Text = "Sky Blue";
			this.lan.checkBox3.Text = "Top Most";
			this.lan.flatButton229.Text = "Click To Choose Language";
			this.lan.flatButton115.Text = "Home";
			this.lan.flatButton151.Text = "Close Roblox";
			this.lan.flatButton245.Text = "Vip Servers";
			this.lan.flatButton247.Text = "Settings";
			this.lan.label6.Text = "Changelog:";
			this.lan.richTextBox40.Text = "Date: 25/11/2018 (Merry christmas! for most people)\r\n-------------------------------------------\r\n-Added christmas theme\r\n-Added a bunch of new games\r\nDate: 30/11/201\r\n--------------------------------------------\r\n- Added a new language(Polish)\r\nDate: 16/11/2018\r\n--------------------------------------------\r\n - Added more games!\r\nx Removed dead buttons:^)\r\nDate: 21/10/2018\r\n--------------------------------------------\r\n- More Stability\r\n- Try out other scripts and use on the Full Lua\r\n-Increased Injection Speed!\r\nx Implemented a fix for most injections\r\nDate: 13 /10/2018\r\n--------------------------------------------\r\n- Added Few More CMDS\r\n- Added Full Lua Compatibility\r\n- Faster and secure\r\n- Added Languages(German, Italian, French & Russian)\r\nx Removed All Junk CMDS(Patched Ones)";
			this.lan.formSkin1.Refresh();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000029A8 File Offset: 0x00000BA8
		private void button3_Click(object sender, EventArgs e)
		{
			this.lan.flatButton1.Text = "Iniettare";
			this.lan.flatLabel1.Text = "Iscriviti a Nonsense Diamond su Youtube per ulteriori \naggiornamenti!";
			this.lan.flatLabel3.Text = "STATO:";
			this.lan.flatButton86.Text = "⮎ Visita il sito web";
			this.lan.flatButton27.Text = "Cercare Aggiornamenti✔";
			this.lan.flatButton3.Text = "➼ Iscriviti a Giveaways";
			this.lan.flatButton2.Text = "Sottoscrivi ☺ ";
			this.lan.flatButton21.Text = "Eseguire";
			this.lan.flatButton38.Text = "Chiaro";
			this.lan.flatButton41.Text = "Aperto";
			this.lan.checkBox1.Text = "Arcobaleno";
			this.lan.label1.Text = "Cambia Colore";
			this.lan.flatButton137.Text = "verde";
			this.lan.flatButton139.Text = "Blu";
			this.lan.flatButton149.Text = "Nero";
			this.lan.flatButton140.Text = "Arancia";
			this.lan.flatButton141.Text = "Rosso";
			this.lan.flatButton148.Text = "Grigio";
			this.lan.flatButton142.Text = "Verde Acqua";
			this.lan.flatButton143.Text = "Oro";
			this.lan.flatButton147.Text = "Rosa";
			this.lan.flatButton144.Text = "Predefinito(Viola)";
			this.lan.flatButton145.Text = "Cadetto Blu";
			this.lan.flatButton146.Text = "Cielo Blu";
			this.lan.checkBox3.Text = "In Cima";
			this.lan.flatButton229.Text = "Scegliere La Lingua";
			this.lan.flatButton115.Text = "Casa";
			this.lan.flatButton151.Text = "Chiudi Roblox";
			this.lan.flatButton245.Text = "Server VIPs";
			this.lan.flatButton247.Text = "impostazioni";
			this.lan.label6.Text = "Changelog:";
			this.lan.richTextBox40.Text = "Data: 25/11/2018 (Buon Natale! Per la maggior parte delle persone)\r\n-------------------------------------------\r\n-Aggiunto il tema natale\r\n- Aggiunti un sacco di nuovi giochi\r\nData: 30/11/2018\r\n--------------------------------------------\r\n- Aggiunta una nuova lingua(polacco)\r\nData: 16/11/2018\r\n--------------------------------------------\r\n- Aggiunti altri giochi!\r\nx Pulsanti morti rimossi:^)\r\nData: 21/10/2018\r\n--------------------------------------------\r\n- Più stabilità\r\n- Prova altri script e utilizzali su Full Lua\r\n- Aumento della velocità di iniezione!\r\nx Implementata una correzione per la maggior parte delle iniezioni\r\nData: 13/10/2018\r\n--------------------------------------------\r\n- Aggiunti altri CMDS\r\n-Aggiunta la piena compatibilità Lua\r\n- Più veloce e sicuro\r\n- Lingue aggiunte(tedesco, italiano, francese e russo)\r\nx Removed All Junk CMDS(Patched Ones)";
			this.lan.formSkin1.Refresh();
		}

		// Token: 0x06000016 RID: 22
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000017 RID: 23
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000018 RID: 24 RVA: 0x00002C87 File Offset: 0x00000E87
		private void button7_Click(object sender, EventArgs e)
		{
			base.Hide();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002C94 File Offset: 0x00000E94
		private void panel2_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				Languages.ReleaseCapture();
				Languages.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002CD0 File Offset: 0x00000ED0
		private void button4_Click(object sender, EventArgs e)
		{
			this.lan.flatButton1.Text = "Injizieren";
			this.lan.flatLabel1.Text = "Abonnieren Sie Nonsense Diamond auf Youtube für weitere \nUpdates!";
			this.lan.flatLabel3.Text = "STATUS:";
			this.lan.flatButton86.Text = "⮎ Besuche die Website";
			this.lan.flatButton27.Text = "Suche nach Aktualisierung✔";
			this.lan.flatButton3.Text = "➼ Werbegeschenke beitreten";
			this.lan.flatButton2.Text = "Abonnieren ☺ ";
			this.lan.flatButton21.Text = "Ausführen";
			this.lan.flatButton38.Text = "Klar";
			this.lan.flatButton41.Text = "Öffnen";
			this.lan.checkBox1.Text = "Regenbogen";
			this.lan.label1.Text = "Farbe ändern";
			this.lan.flatButton137.Text = "Grün";
			this.lan.flatButton139.Text = "Blau";
			this.lan.flatButton149.Text = "Schwarz";
			this.lan.flatButton140.Text = "Orange";
			this.lan.flatButton141.Text = "Rot";
			this.lan.flatButton148.Text = "Grau";
			this.lan.flatButton142.Text = "Knickente";
			this.lan.flatButton143.Text = "Gold";
			this.lan.flatButton147.Text = "Rosa";
			this.lan.flatButton144.Text = "Standard(Lila)";
			this.lan.flatButton145.Text = "Kadettenblau";
			this.lan.flatButton146.Text = "Himmelblau";
			this.lan.checkBox3.Text = "Oben Drauf";
			this.lan.flatButton229.Text = "Sprache Wählen";
			this.lan.flatButton115.Text = "Zuhause";
			this.lan.flatButton151.Text = "Schließen Roblox";
			this.lan.flatButton245.Text = "Vip Servers";
			this.lan.flatButton247.Text = "Die Einstellungen";
			this.lan.label6.Text = "Änderungsprotokoll:";
			this.lan.richTextBox40.Text = "Datum: 25.11.2018 (Frohe Weihnachten! Für die meisten Leute)\r\n---------------------------------------\r\n-Weihnachtsthema hinzugefügt\r\n- Ein paar neue Spiele hinzugefügt\r\nDatum: 30.11.2018\r\n----------------------------------------\r\n- Neue Sprache hinzugefügt(Polnisch)\r\nDatum: 16.11.2018\r\n----------------------------------------\r\n- Weitere Spiele hinzugefügt!\r\nx entfernte tote Knöpfe:^)\r\nDatum: 21.10.2018\r\n--------------------------------------------\r\n- Mehr Stabilität\r\n- Probieren Sie andere Skripte aus und verwenden Sie das Full Lua\r\n-Erhöhte Injektionsgeschwindigkeit!\r\nx Implementiert einen Fix für die meisten Injektionen\r\nDatum: 13.10.2018\r\n--------------------------------------------\r\n- Es wurden nur wenige CMDS hinzugefügt\r\n- Komplette Lua - Kompatibilität hinzugefügt\r\n- Schneller und sicherer\r\n- Sprachen hinzugefügt(Deutsch, Italienisch, Französisch und Russisch)\r\nx Alle Junk - CMDS entfernt(gepatchte)";
			this.lan.formSkin1.Refresh();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002FB0 File Offset: 0x000011B0
		private void button5_Click(object sender, EventArgs e)
		{
			this.lan.flatButton1.Text = "Injecter";
			this.lan.flatLabel1.Text = "Abonnez-vous à Nonsense Diamond sur Youtube pour plus de \nmises à jour!";
			this.lan.flatLabel3.Text = "STATUT:";
			this.lan.flatButton86.Text = "⮎ Visiter Le Site Web";
			this.lan.flatButton27.Text = "Rechercher Des Mises À Jour✔";
			this.lan.flatButton3.Text = "➼ Rejoignez Les Cadeaux";
			this.lan.flatButton2.Text = "Souscrire ☺ ";
			this.lan.flatButton21.Text = "Exécuter";
			this.lan.flatButton38.Text = "Clair";
			this.lan.flatButton41.Text = "Ouvrir";
			this.lan.checkBox1.Text = "Arc En Ciel";
			this.lan.label1.Text = "Changer De Couleur";
			this.lan.flatButton137.Text = "Vert";
			this.lan.flatButton139.Text = "Bleu";
			this.lan.flatButton149.Text = "Noir";
			this.lan.flatButton140.Text = "Orange";
			this.lan.flatButton141.Text = "Rouge";
			this.lan.flatButton148.Text = "Gris";
			this.lan.flatButton142.Text = "Sarcelle";
			this.lan.flatButton143.Text = "Or";
			this.lan.flatButton147.Text = "Rose";
			this.lan.flatButton144.Text = "Par Défaut(Violet)";
			this.lan.flatButton145.Text = "Bleu Cadet";
			this.lan.flatButton146.Text = "Bleu Ciel";
			this.lan.checkBox3.Text = "En Haut";
			this.lan.flatButton229.Text = "Choisissez la langue";
			this.lan.flatButton115.Text = "Maison";
			this.lan.flatButton151.Text = "Fermer Roblox";
			this.lan.flatButton245.Text = "Serveurs Vip";
			this.lan.flatButton247.Text = "Réglages";
			this.lan.label6.Text = "Changelog:";
			this.lan.richTextBox40.Text = "Date: 30/11/2018\r\n------------------------------------------------\r\n- Ajout d'une nouvelle langue (polonais)\r\nDate: 16/11/2018\r\n------------------------------------------------\r\n- Ajout de plus de jeux!\r\nx Suppression des boutons morts:^)\r\nDate: 21/10/2018 \r\n --------------------------------------------\r\n- Plus de stabilité \r\n- Essayez d'autres scripts et utilisez-les sur Full Lua\r\n- Augmentation de la vitesse d'injection!\r\nx Mise en oeuvre d'un correctif pour la plupart des injections\r\nDate: 13/10/2018\r\n------------------------------------------------\r\n- Ajout de peu plus de CMDS\r\n- Ajout de la compatibilité totale de Lua\r\n- Plus rapide et sécurisé\r\n- Langues ajoutées(allemand, italien, français et russe)\r\nx Suppression de tous les CMDS indésirables(corrigés)";
			this.lan.formSkin1.Refresh();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003290 File Offset: 0x00001490
		private void button6_Click(object sender, EventArgs e)
		{
			this.lan.flatButton1.Text = "впрыскивать";
			this.lan.flatLabel1.Text = "Подпишитесь на Nonsense Diamond на Youtube для получения \nдополнительных обновлений!";
			this.lan.flatLabel3.Text = "ПОЛОЖЕНИЕ ДЕЛ:";
			this.lan.flatButton86.Text = "⮎ Посетите сайт";
			this.lan.flatButton27.Text = "Поиск обновлений✔";
			this.lan.flatButton3.Text = "➼ Присоединяйтесь к подаркам";
			this.lan.flatButton2.Text = "Подписывайся ☺ ";
			this.lan.flatButton21.Text = "казнить";
			this.lan.flatButton38.Text = "Очистить";
			this.lan.flatButton41.Text = "открыто";
			this.lan.checkBox1.Text = "радуга";
			this.lan.label1.Text = "Изменить цвет";
			this.lan.flatButton137.Text = "зеленый";
			this.lan.flatButton139.Text = "синий";
			this.lan.flatButton149.Text = "черный";
			this.lan.flatButton140.Text = "оранжевый";
			this.lan.flatButton141.Text = "красный";
			this.lan.flatButton148.Text = "серый";
			this.lan.flatButton142.Text = "чирок";
			this.lan.flatButton143.Text = "Золото";
			this.lan.flatButton147.Text = "розовый";
			this.lan.flatButton144.Text = "По умолчанию(фиолетовый)";
			this.lan.flatButton145.Text = "Кадетский синий";
			this.lan.flatButton146.Text = "голубое небо";
			this.lan.checkBox3.Text = "Наверху";
			this.lan.flatButton229.Text = "Выберите язык";
			this.lan.flatButton115.Text = "инициирование";
			this.lan.flatButton151.Text = "Закрыть Roblox";
			this.lan.flatButton245.Text = "Серверы Vip";
			this.lan.flatButton247.Text = "настройки";
			this.lan.label6.Text = "изменений:";
			this.lan.richTextBox40.Text = "Дата: 30/11/2018\r\n--------------------------------------------\r\n- Добавлен новый язык(польский)\r\nДата: 16/11/2018\r\n--------------------------------------------\r\n- Добавлено больше игр!\r\nx Удаленные мертвые кнопки:^)\r\nДата: 21 / 10 / 2018\r\n--------------------------------------------\r\n- Больше стабильности\r\n- Попробуйте другие скрипты и используйте на Full Lua\r\n- Увеличенная скорость впрыска!\r\nx Реализовано исправление для большинства инъекций\r\nДата: 13/10/2018\r\n--------------------------------------------\r\n- Добавлено несколько CMDS\r\n- Добавлена ​​полная совместимость Lua\r\n- Быстрее и безопаснее\r\n- Добавлены языки(немецкий, итальянский, французский и русский)\r\nx Удалено все нежелательные CMDS(исправленные)";
			this.lan.formSkin1.Refresh();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003570 File Offset: 0x00001770
		private void button8_Click(object sender, EventArgs e)
		{
			this.lan.flatButton1.Text = "Wstrzykiwać";
			this.lan.flatLabel1.Text = "Subskrybuj Nonsense Diamond On Youtube Więcej informacji!";
			this.lan.flatLabel3.Text = "STATUS:";
			this.lan.flatButton86.Text = "⮎ Odwiedź stronę";
			this.lan.flatButton27.Text = "Sprawdź aktualizacje✔";
			this.lan.flatButton3.Text = "➼ Kliknij, aby dołączyć do prezentów";
			this.lan.flatButton2.Text = "Kliknij, aby zasubskrybować ☺ ";
			this.lan.flatButton21.Text = "Wykonać";
			this.lan.flatButton38.Text = "Jasny";
			this.lan.flatButton41.Text = "Otwarty";
			this.lan.checkBox1.Text = "Tęcza";
			this.lan.label1.Text = "Zmień kolor";
			this.lan.flatButton137.Text = "Zielony";
			this.lan.flatButton139.Text = "Niebieski";
			this.lan.flatButton149.Text = "Czarny";
			this.lan.flatButton140.Text = "Pomarańczowy";
			this.lan.flatButton141.Text = "Czerwony";
			this.lan.flatButton148.Text = "Szary";
			this.lan.flatButton142.Text = "Cyraneczka";
			this.lan.flatButton143.Text = "Złoto";
			this.lan.flatButton147.Text = "Różowy";
			this.lan.flatButton144.Text = "Domyślny(fioletowy)";
			this.lan.flatButton145.Text = "Cadet Blue";
			this.lan.flatButton146.Text = "Niebieskie Niebo";
			this.lan.checkBox3.Text = "Najwyżej";
			this.lan.flatButton229.Text = "Kliknij, aby wybrać język";
			this.lan.flatButton115.Text = "Dom";
			this.lan.flatButton151.Text = "Zamknij Roblox";
			this.lan.flatButton245.Text = "Serwery VIP";
			this.lan.flatButton247.Text = "Ustawienia";
			this.lan.label6.Text = "Dziennik zmian:";
			this.lan.richTextBox40.Text = "Data: 30.11.2018\r\n--------------------------------------------\r\n- Dodano nowy język(polski)\r\nData: 16/11/2018\r\n--------------------------------------------\r\n- Dodano więcej gier!\r\nx Usunięto martwe przyciski: ^)\r\nData: 21/10/2018\r\n--------------------------------------------\r\n- Większa stabilność\r\n- Wypróbuj inne skrypty i użyj na Full Lua\r\n- Zwiększona prędkość wtrysku!\r\nx Wdrożono poprawkę dla większości zastrzyków\r\nData: 13/10/2018\r\n--------------------------------------------\r\n- Dodano niewiele więcej CMDS \r\n- Dodano pełną kompatybilność Lua \r\n- Szybciej i bezpieczniej \r\n- Dodano języki (niemiecki, włoski, francuski i rosyjski)\r\nx Usunięto wszystkie niepotrzebne CMDS (poprawione)";
			this.lan.formSkin1.Refresh();
		}

		// Token: 0x0400000D RID: 13
		public Form3 lan;

		// Token: 0x0400000E RID: 14
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x0400000F RID: 15
		public const int HT_CAPTION = 2;
	}
}
