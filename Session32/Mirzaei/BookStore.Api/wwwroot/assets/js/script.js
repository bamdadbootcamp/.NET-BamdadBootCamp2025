const API_BASE = "https://localhost:7217";
const form = document.getElementById("loginForm");
const msg = document.getElementById("msg");
const btn = form.querySelector('button[type="submit"]');
const url = `${API_BASE}/api/auth/login`;

function getPayload() {
  return {
    userName: document.getElementById("userName").value.trim(),
    password: document.getElementById("password").value,
  };
}

function waitForSubmit() {
  return new Promise((resolve) => {
    const handler = (e) => {
      e.preventDefault();
      resolve(getPayload());
    };
    form.addEventListener("submit", handler, { once: true });
  });
}

async function loginLoop() {
  while (true) {
    const payload = await waitForSubmit();

    try {
      btn.disabled = true;
      msg.style.color = "";
      msg.textContent = "در حال بررسی...";

      const res = await fetch(url, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(payload),
      });

      if (res.ok) {
        msg.style.color = "green";
        msg.textContent = "ورود موفق 👌 ... در حال انتقال";
        await new Promise((r) => setTimeout(r, 1200));
        window.location.assign("../index.html");
        break;
      } else if (res.status === 401) {
        msg.style.color = "crimson";
        msg.textContent =
          "نام کاربری یا رمز عبور نادرست است. دوباره امتحان کنید.";
        document.getElementById("password").value = "";
        document.getElementById("password").focus();
      } else {
        msg.style.color = "crimson";
        msg.textContent = `خطای سرور (${res.status})`;
      }
    } catch (err) {
      console.error(err);
      msg.style.color = "crimson";
      msg.textContent = "عدم دسترسی به سرور";
    } finally {
      btn.disabled = false;
    }
  }
}

loginLoop();
