using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LettoreVideo.Classi
{
    public class TooltipManager
    {
        private ToolTip _toolTip;

        /// <summary>
        /// Inizializza TooltipManager con impostazioni base.
        /// </summary>
        public TooltipManager()
        {
            _toolTip = new ToolTip
            {
                AutoPopDelay = 5000,   // tempo che resta visibile
                InitialDelay = 500,    // tempo prima di apparire
                ReshowDelay = 200,     // tempo prima di riapparire
                ShowAlways = true      // mostra anche se il form non è attivo
            };
        }

        /// <summary>
        /// Imposta un tooltip su un controllo
        /// </summary>
        /// <param name="control">Controllo su cui mostrare il tooltip</param>
        /// <param name="message">Testo del tooltip</param>
        public void SetTooltip(Control control, string message)
        {
            _toolTip.SetToolTip(control, message);
        }

        /// <summary>
        /// Rimuove il tooltip da un controllo
        /// </summary>
        public void RemoveTooltip(Control control)
        {
            _toolTip.SetToolTip(control, string.Empty);
        }

        /// <summary>
        /// Imposta tooltip avanzati con icone o formattazione (solo testo semplice)
        /// </summary>
        public void SetAdvancedTooltip(Control control, string message, ToolTipIcon icon = ToolTipIcon.Info, bool balloon = false)
        {
            _toolTip.ToolTipIcon = icon;
            _toolTip.IsBalloon = balloon;
            _toolTip.SetToolTip(control, message);
        }
    }

    public class TooltipManager2
    {
        // Manteniamo un ToolTip per ogni controllo per poter personalizzare indipendentemente
        private Dictionary<Control, ToolTip> _tooltips;

        public TooltipManager2()
        {
            _tooltips = new Dictionary<Control, ToolTip>();
        }

        /// <summary>
        /// Imposta un tooltip su un controllo, con opzioni avanzate.
        /// </summary>
        /// <param name="control">Controllo target</param>
        /// <param name="text">Testo del tooltip</param>
        /// <param name="isBalloon">Se true, mostra balloon</param>
        /// <param name="icon">Icona del tooltip (Info, Warning, Error, None)</param>
        /// <param name="backColor">Colore di sfondo</param>
        /// <param name="foreColor">Colore del testo</param>
        /// <param name="font">Font personalizzato</param>
        /// <param name="autoPopDelay">Tempo di permanenza in ms</param>
        /// <param name="initialDelay">Ritardo iniziale in ms</param>
        /// <param name="reshowDelay">Ritardo di riapparizione in ms</param>
        public void SetTooltip(
            Control control,
            string text,
            bool isBalloon = false,
            ToolTipIcon icon = ToolTipIcon.None,
            Color? backColor = null,
            Color? foreColor = null,
            Font font = null,
            int autoPopDelay = 5000,
            int initialDelay = 500,
            int reshowDelay = 200)
        {
            if (!_tooltips.ContainsKey(control))
            {
                ToolTip tip = new ToolTip
                {
                    IsBalloon = isBalloon,
                    OwnerDraw = (backColor != null || foreColor != null || font != null),
                    AutoPopDelay = autoPopDelay,
                    InitialDelay = initialDelay,
                    ReshowDelay = reshowDelay,
                    ShowAlways = true
                };

                if (tip.OwnerDraw)
                {
                    tip.Draw += (sender, e) =>
                    {
                        e.Graphics.FillRectangle(new SolidBrush(backColor ?? SystemColors.Info), e.Bounds);
                        using (Font drawFont = font ?? e.Font)
                        using (Brush drawBrush = new SolidBrush(foreColor ?? SystemColors.InfoText))
                        {
                            e.Graphics.DrawString(e.ToolTipText, drawFont, drawBrush, e.Bounds);
                        }
                    };
                }

                _tooltips.Add(control, tip);
            }

            _tooltips[control].SetToolTip(control, text);
        }

        /// <summary>
        /// Rimuove il tooltip da un controllo
        /// </summary>
        public void RemoveTooltip(Control control)
        {
            if (_tooltips.ContainsKey(control))
            {
                _tooltips[control].RemoveAll();
                _tooltips.Remove(control);
            }
        }

        /// <summary>
        /// Aggiorna il testo di un tooltip esistente
        /// </summary>
        public void UpdateTooltipText(Control control, string newText)
        {
            if (_tooltips.ContainsKey(control))
            {
                _tooltips[control].SetToolTip(control, newText);
            }
        }
    }
}
